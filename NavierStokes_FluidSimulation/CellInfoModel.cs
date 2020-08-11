using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavierStokes_FluidSimulation
{
    public struct CellInfoModel
    {
        readonly public double VelocityX;
        readonly public double VelocityY;
        readonly public double DyeR;
        readonly public double DyeG;
        readonly public double DyeB;

        public CellInfoModel(double vX, double vY, double dyeR, double dyeG, double dyeB)
        {
            VelocityX = vX;
            VelocityY = vY;
            DyeR = dyeR;
            DyeG = dyeG;
            DyeB = dyeB;
        }

        public Color Color
        {
            get
            {
                return Color.FromArgb((int)Math.Min(255, DyeR), (int)Math.Min(255, DyeG), (int)Math.Min(255, DyeB));
            }
        }
    }
}
