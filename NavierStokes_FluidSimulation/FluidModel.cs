using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Implement: https://mikeash.com/pyblog/fluid-simulation-for-dummies.html
/// </summary>
namespace NavierStokes_FluidSimulation
{
    class FluidModel
    {
        #region Main Fields
        private int _width = 0;
        private int _height = 0;
        public int Width
        {
            get => _width;
            private set => _width = value;
        }
        public int Height
        {
            get => _height;
            private set => _height = value;
        }

        public double TimeStep = 0.00002d;
        public double Diffusion = 0.1d;
        public double Viscosity = 0d;
        public double Buoyancy = 0d;
        public int Iteration = 20;

        private List<List<double>> PrevDyeR;
        private List<List<double>> DyeR;
        private List<List<double>> PrevDyeG;
        private List<List<double>> DyeG;
        private List<List<double>> PrevDyeB;
        private List<List<double>> DyeB;

        private List<List<double>> PrevVelocityX;
        private List<List<double>> VelocityX;
        
        private List<List<double>> PrevVelocityY;
        private List<List<double>> VelocityY;

        private enum StateType { Free, Adding, Updating }
        private StateType State;

        public CellInfoModel this[int x, int y]
        {
            get
            {
                if(IsValidIndex(x,y))
                    return new CellInfoModel(VelocityX[x][y], VelocityY[x][y], DyeR[x][y], DyeG[x][y], DyeB[x][y]);
                else
                    return new CellInfoModel(0, 0, 0, 0, 0);
            }
        }
        #endregion

        #region Creation
        public FluidModel(int width, int height)
        {
            Width = width;
            Height = height;
            CreateData();
        }

        private List<List<double>> Create2DList(int width, int height, double value = 0)
        {
            var result = new List<List<double>>();

            for(int i=0; i<width; i++)
            {
                var temp = Enumerable.Repeat(value, height).ToList();
                result.Add(temp);
            }

            return result;
        }

        /// <summary>
        /// Initialize all model array.
        /// </summary>
        private void CreateData()
        {
            DyeR            = Create2DList(Width, Height);
            PrevDyeR        = Create2DList(Width, Height);
            DyeG            = Create2DList(Width, Height);
            PrevDyeG        = Create2DList(Width, Height);
            DyeB            = Create2DList(Width, Height);
            PrevDyeB        = Create2DList(Width, Height);
            VelocityX       = Create2DList(Width, Height);
            PrevVelocityX   = Create2DList(Width, Height);
            VelocityY       = Create2DList(Width, Height);
            PrevVelocityY   = Create2DList(Width, Height);
        }
        #endregion

        #region Operations
        private bool IsValidIndex(int x, int y)
        {
            if(x < 0 || x >= Width)
                return false;

            if(y < 0 || y >= Height)
                return false;

            return true;
        }

        private void AddCommon(List<List<double>> l, int x, int y, double amount)
        {
            if(!IsValidIndex(x,y))
                return;

            // busy waiting
            while(State != StateType.Free);
           
            State = StateType.Adding;
            l[x][y] += amount;
            State = StateType.Free;
        }

        public void AddDyeR(int x, int y, double amount)
        {
            AddCommon(DyeR, x, y, amount);
        }

        public void AddDyeG(int x, int y, double amount)
        {
            AddCommon(DyeG, x, y, amount);
        }

        public void AddDyeB(int x, int y, double amount)
        {
            AddCommon(DyeB, x, y, amount);
        }

        public void AddDye(int x, int y, Color color, double amount = 1)
        {
            AddDyeR(x, y, color.R * amount);
            AddDyeG(x, y, color.G * amount);
            AddDyeB(x, y, color.B * amount);
        }

        public void AddVelocity(int x, int y, double amountX, double amountY)
        {
            AddCommon(VelocityX, x, y, amountX);
            AddCommon(VelocityY, x, y, amountY);
        }

        public void Clear()
        {
            CreateData();
        }
        #endregion

        #region Evaluation and Updating
        public void FrameUpdate()
        {
            while(State != StateType.Free);
            State = StateType.Updating;
            
            Sink();

            Diffuse(PrevVelocityX, VelocityX, Viscosity, BoundOption.BoundVertical);
            Diffuse(PrevVelocityY, VelocityY, Viscosity, BoundOption.BoundHorizontal);

            Project(PrevVelocityX, PrevVelocityY, VelocityX, VelocityY);

            Advect(VelocityX, PrevVelocityX, PrevVelocityX, PrevVelocityY, BoundOption.BoundVertical);
            Advect(VelocityY, PrevVelocityY, PrevVelocityX, PrevVelocityY, BoundOption.BoundHorizontal);

            Project(VelocityX, VelocityY, PrevVelocityX, PrevVelocityY);

            Diffuse(PrevDyeR, DyeR, Diffusion, BoundOption.None);
            Diffuse(PrevDyeG, DyeG, Diffusion, BoundOption.None);
            Diffuse(PrevDyeB, DyeB, Diffusion, BoundOption.None);
            Advect(DyeR, PrevDyeR, VelocityX, VelocityY, BoundOption.None);
            Advect(DyeG, PrevDyeG, VelocityX, VelocityY, BoundOption.None);
            Advect(DyeB, PrevDyeB, VelocityX, VelocityY, BoundOption.None);

            State = StateType.Free;
        }

        #region Set Bound
        enum BoundOption { None, BoundVertical, BoundHorizontal }

        /// <summary>
        /// WARNING: mutate the array!
        /// </summary>
        /// <param name="array"></param>
        private void SetBound(List<List<double>> array, BoundOption bndOpt)
        {
            for (int x=1; x<Width-1; x++)
            {
                array[x][0         ] = bndOpt==BoundOption.BoundHorizontal? -array[x][1         ] : array[x][1         ];
                array[x][Height - 1] = bndOpt==BoundOption.BoundHorizontal? -array[x][Height - 2] : array[x][Height - 2];
            }

            for (int y=1; y<Height-1; y++)
            {
                array[0        ][y] = bndOpt==BoundOption.BoundVertical? -array[1        ][y] : array[1        ][y];
                array[Width - 1][y] = bndOpt==BoundOption.BoundVertical? -array[Width - 2][y] : array[Width - 2][y];
            }
            
            array[0      ][0       ] = ( array[0      ][1       ] + array[1      ][0       ] ) / 2d;
            array[0      ][Height-1] = ( array[0      ][Height-2] + array[1      ][Height-1] ) / 2d;
            array[Width-1][0       ] = ( array[Width-1][1       ] + array[Width-2][0       ] ) / 2d;
            array[Width-1][Height-1] = ( array[Width-1][Height-2] + array[Width-2][Height-1] ) / 2d;
        }
        #endregion

        #region Solve Linear
        /// <summary>
        /// WARNING: mutate array
        /// mysterious function :)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="prevArray"></param>
        /// <param name="a"></param>
        /// <param name="c"></param>
        /// <param name="boundAction"></para
        private void SolveLinear(List<List<double>> array, List<List<double>> prevArray, double a, double c, BoundOption bndOpt)
        {
            List<List<double>> temp;
            for (int i = 0; i < Iteration; i++)
            {
                for (int x = 1; x < Width - 1; x++)
                    for (int y = 1; y < Height - 1; y++)
                    {
                        double sumNeighbor = array[x + 1][y] + array[x - 1][y] + array[x][y + 1] + array[x][y - 1];
                        array[x][y] = (prevArray[x][y] + a * sumNeighbor) / c;
                    }

                SetBound(array, bndOpt);
            }
        }
        #endregion

        #region Diffuse
        /// <summary>
        /// WARNING: mutate array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="prevArray"></param>
        /// <param name="diffusion"></param>
        /// <param name="bndOpt"></param>
        private void Diffuse(List<List<double>> array, List<List<double>> prevArray, double diffusion, BoundOption bndOpt)
        {
            // OOPS: I DONT UNDERSTAND THIS :)
            double a = TimeStep * diffusion * (Width - 2) * (Height - 2);
            SolveLinear(array, prevArray, a, 1 + 4 * a, bndOpt);
        }
        #endregion

        #region Project
        /// <summary>
        /// WARNING: mutate vX, vY, p, div (all)
        /// </summary>
        /// <param name="vX"></param>
        /// <param name="vY"></param>
        /// <param name="p"></param>
        /// <param name="div"></param>
        private void Project(List<List<double>> vX, List<List<double>> vY, List<List<double>> p, List<List<double>> div)
        {
            for (int x = 1; x < Width - 1; x++)
                for (int y = 1; y < Height - 1; y++)
                { 
                    div[x][y] = -0.5d * ( (vX[x+1][y] - vX[x-1][y])/Height + (vY[x][y+1] - vY[x][y-1])/Width );
                    p[x][y] = 0;
                }

            SetBound(div, BoundOption.None);
            SetBound(p, BoundOption.None);
            SolveLinear(p, div, 1, 4, BoundOption.None);

            for (int x = 1; x < Width - 1; x++)
                for (int y = 1; y < Height - 1; y++)
                {
                    vX[x][y] -= 0.5d * (p[x+1][y] - p[x-1][y]) * Height;
                    vY[x][y] -= 0.5d * (p[x][y+1] - p[x][y-1]) * Width;
                }

            SetBound(vX, BoundOption.BoundVertical);
            SetBound(vY, BoundOption.BoundHorizontal);
        }
        #endregion

        #region Advect
        /// <summary>
        /// WARNING: mutate array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="prevArray"></param>
        /// <param name="vX"></param>
        /// <param name="vY"></param>
        /// <param name="bndOpt"></param>
        private void Advect(List<List<double>> array, List<List<double>> prevArray, List<List<double>> vX, List<List<double>> vY, BoundOption bndOpt)
        {
            // OOPS: I DONT KNOW AGAIN :)
            double dtx = TimeStep * (Width - 2);
            double dty = TimeStep * (Height - 2);

            double x0, x1, y0, y1;
            double s0, s1, t0, t1;
            double tmp1, tmp2, x, y;

            for (int xi = 1; xi < Width - 1; xi++)
                for (int yi = 1; yi < Height - 1; yi++)
                {
                    tmp1 = dtx * vX[xi][yi];
                    tmp2 = dty * vY[xi][yi];
                    x = (double)xi - tmp1;
                    y = (double)yi - tmp2;

                    x = Math.Max(x, 0.5d);
                    x = Math.Min(x, Width + 0.5d);
                    x0 = Math.Floor(x);
                    x1 = x0 + 1.0d;

                    y = Math.Max(y, 0.5d);
                    y = Math.Min(y, Height + 0.5d);
                    y0 = Math.Floor(y);
                    y1 = y0 + 1.0d;

                    s1 = x - x0;
                    s0 = 1.0d - s1;
                    t1 = y - y0;
                    t0 = 1.0d - t1;

                    // really really bad var names tbh
                    int x0i = (int)x0;
                    int x1i = (int)x1;
                    int y0i = (int)y0;
                    int y1i = (int)y1;

                    if(IsValidIndex(x0i,y0i) && IsValidIndex(x1i,y1i))
                        array[xi][yi] =
                            s0 * (t0 * prevArray[x0i][y0i] + t1 * prevArray[x0i][y1i]) +
                            s1 * (t0 * prevArray[x1i][y0i] + t1 * prevArray[x1i][y1i]);
                }

            SetBound(array, bndOpt);
        }
        #endregion

        #region Sink
        private void Sink()
        {
            for(int x=0; x<Width; x++)
                for(int y=0; y<Height-1; y++)
                {
                    double mass = DyeR[x][y] + DyeG[x][y] + DyeB[x][y];
                    VelocityY[x][y] -= mass*Buoyancy;
                }
        }
        #endregion

        #endregion

        #region Optimization



        #endregion
    }
}
