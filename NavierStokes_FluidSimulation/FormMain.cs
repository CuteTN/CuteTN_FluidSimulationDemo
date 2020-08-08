using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavierStokes_FluidSimulation
{
    public partial class FormMain : Form
    {
        FluidModel Fluid;

        #region Initialize
        public FormMain()
        {
            InitializeComponent();
            CustomInit();
        }

        private void CustomInit()
        {
            Fluid = new FluidModel(100, 100);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);

            foreach(var c in Controls)
            { 
                if(c is NumericUpDown)
                {
                    var nud = c as NumericUpDown;
                    nud.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
                    nud.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
                }
                if(c is CheckBox)
                {
                    var cb = c as CheckBox;
                    cb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
                    cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
                }
                if(c is Button)
                {
                    var b = c as Button;
                    b.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
                    b.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
                }
                if(c is ComboBox)
                {
                    var cb = c as ComboBox;
                    cb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
                    cb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
                }
            }

            MouseWheel += FormMain_MouseWheel;

            InitDefaultSettingValue();
            Timer.Start();
        }
        #endregion

        #region Event KeyDown

        private void HandleHotkeysDown(KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    {
                        Application.Exit();
                        break;
                    }
                case Keys.Back:
                    {
                        if(e.Shift)
                            Fluid.Clear();
                        break;
                    }
                case Keys.V:
                    {
                        EnableRenderVelocity = !EnableRenderVelocity;
                        break;
                    }
                case Keys.P:
                    {
                        IsPaused = !IsPaused;
                        break;
                    }
                case Keys.H:
                    {
                        EnabledHoldMode = !EnabledHoldMode;
                        break;
                    }
                case Keys.R:
                    {
                        FlowStrengthToAdd = -FlowStrengthToAdd;
                        break;
                    }
                case Keys.ControlKey:
                    {
                        ControlKeyIsDown = true;
                        break;
                    }

                default:
                    break;
            }
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            HandleHotkeysDown(e);
        }

        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.ControlKey)
                ControlKeyIsDown = false;
        }
        #endregion

        #region Timer and Frame Update
        System.Windows.Forms.Timer _timer = null;
        System.Windows.Forms.Timer Timer
        {
            get
            {
                if(_timer == null)
                {
                    _timer = new System.Windows.Forms.Timer();
                    _timer.Interval = 10;
                    _timer.Tick += Timer_Tick;
                }
                return _timer;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            HandleMouseDownHoldMode();
            Refresh();

            /*
            //TEST
            if(DateTime.Now.Second % 1 == 0)
            { 
                Fluid.AddVelocity(45, 45, 5000, 0);
                Fluid.AddVelocity(55, 45, 0, 5000);
                Fluid.AddVelocity(55, 55, -5000, 0);
                Fluid.AddVelocity(45, 55, 0, -5000);
            }*/
            
            if(!IsPaused)
                Fluid.FrameUpdate();
        }


        #endregion

        #region Rendering
        private void RenderFluid(Graphics graphics, Rectangle area)
        {
            float cellW = (float)area.Width / Fluid.Width;
            float cellH = (float)area.Height / Fluid.Height;
            SolidBrush b = new SolidBrush(Color.Black);
            RectangleF cellRect = new RectangleF(0, 0, cellW, cellH);
            CellInfoModel cellInfo;

            for (int x=0; x<Fluid.Width; x++)
                for(int y=0; y<Fluid.Height; y++)
                {
                    cellInfo = Fluid[x,y];
                    b.Color = cellInfo.Color;

                    cellRect.X = area.X + x * cellW;
                    cellRect.Y = area.Y + y * cellH;

                    graphics.FillRectangle(b, cellRect);
                }
        }

        private void RenderVelocity(Graphics graphics, Rectangle area)
        {
            if(!EnableRenderVelocity)
                return;

            float cellW = (float)area.Width / Fluid.Width;
            float cellH = (float)area.Height / Fluid.Height;
            Pen p = new Pen(Color.HotPink, 1);
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            RectangleF cellRect = new RectangleF(0, 0, cellW, cellH);
            CellInfoModel cellInfo;

            for (int x = 0; x < Fluid.Width; x+=2)
                for (int y = 0; y < Fluid.Height; y+=2)
                {
                    cellInfo = Fluid[x, y];

                    cellRect.X = area.X + x * cellW;
                    cellRect.Y = area.Y + y * cellH;

                    // render velocity
                    graphics.DrawLine(p, cellRect.X + cellW / 2, cellRect.Y + cellH / 2, cellRect.X + cellW / 2 + (float)cellInfo.VelocityX / 10, cellRect.Y + cellH / 2 + (float)cellInfo.VelocityY / 10);
                }
        }

        private void RenderCursor(Graphics graphics, Rectangle area)
        {
            float EllipseW = (float)(area.Width * CursorRadius / Fluid.Width);
            float EllipseH = (float)(area.Height * CursorRadius / Fluid.Height);

            Brush b = new SolidBrush(Color.FromArgb(20, DyeColor));
            graphics.FillEllipse(b, CurrentMousePos.X - EllipseW, CurrentMousePos.Y - EllipseH, 2*EllipseW, 2*EllipseH);
        }

        public Rectangle FluidRectangle;

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            int RectSize = Math.Min(Width, Height);
            FluidRectangle = new Rectangle(0, 0, RectSize, RectSize);

            e.Graphics.DrawRectangle(new Pen(Color.HotPink), FluidRectangle);
            RenderFluid(e.Graphics, FluidRectangle);
            RenderVelocity(e.Graphics, FluidRectangle);
            RenderCursor(e.Graphics, FluidRectangle);
        }
        #endregion

        #region Mouse Control
        private bool LMouseIsDown = false;
        private bool RMouseIsDown = false;
        private bool ControlKeyIsDown = false;
        private Point CurrentMousePos;
        private Point PreviousMousePos;
        private Point CalMouseCell(Point mousePos)
        {
            float cellW = (float)FluidRectangle.Width / Fluid.Width;
            float cellH = (float)FluidRectangle.Height / Fluid.Height;

            int x = (int)(mousePos.X / cellW);
            int y = (int)(mousePos.Y / cellH);
            return new Point(x,y);
        }

        private double CursorRadius = 3;

        private void HandleMouseDown()
        {
            if (LMouseIsDown)
            {
                var cell = CalMouseCell(CurrentMousePos);
                AddDye(cell, CursorRadius, DyeColor, DyeAmountToAdd);
            }

            if (RMouseIsDown)
            {
                var cell = CalMouseCell(CurrentMousePos);
                var oldCell = CalMouseCell(PreviousMousePos);
                AddVelocity(cell, oldCell, CursorRadius, FlowStrengthToAdd, FlowMode);
            }
        }

        /// <summary>
        /// let user adding source by holding the mouse and control key
        /// </summary>
        private void HandleMouseDownHoldMode()
        {
            if(! (ControlKeyIsDown ^ EnabledHoldMode))
                return;

            HandleMouseDown();
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
                LMouseIsDown = true;
            if(e.Button == MouseButtons.Right)
                RMouseIsDown = true;
            
            HandleMouseDown();
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
                LMouseIsDown = false;
            if(e.Button == MouseButtons.Right)
                RMouseIsDown = false;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            PreviousMousePos = CurrentMousePos;
            CurrentMousePos = e.Location;
        }

        private void FormMain_MouseWheel(object sender, MouseEventArgs e)
        {
            try 
            { 
                numericUpDown_CursorRadius.Value += e.Delta>0? 1:-1;
            }
            catch { }
        }
        #endregion

        #region Fluid Interaction
        /// <summary>
        /// pos: position relative to the FLUID AREA
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="radius"></param>
        /// <param name="color"></param>
        private void AddDye(Point cell, double radius, Color color, double amount)
        {
            Timer.Stop();

            for(int x=(int)Math.Round(cell.X-radius); x<=(int)Math.Round(cell.X + radius); x++)
                for(int y=(int)Math.Round(cell.Y-radius); y<=(int)Math.Round(cell.Y + radius); y++)
                { 
                    Point temp = new Point(x,y);
                    
                    if(Utilities.Distance(temp, cell) <= radius)
                        Fluid.AddDye(temp.X, temp.Y, color, amount);
                }

            Timer.Start();
        }

        enum FlowModeType { Free, Divergence, Curl, Unknown };
        private FlowModeType ToFlowModeType(string s)
        {
            switch(s)
            {
                case "Free": 
                    return FlowModeType.Free;
                case "Divergence":
                    return FlowModeType.Divergence;
                case "Curl":
                    return FlowModeType.Curl;
                default:
                    return FlowModeType.Unknown;
            }
        }

        private FlowModeType FlowMode
        {
            get => ToFlowModeType(comboBox_FlowMode.Text);
        }

        private void AddVelocity(Point cell, Point oldCell, double radius, double strength, FlowModeType flowMode)
        {
            Timer.Stop();

            for (int x = (int)Math.Round(cell.X - radius); x <= (int)Math.Round(cell.X + radius); x++)
                for (int y = (int)Math.Round(cell.Y - radius); y <= (int)Math.Round(cell.Y + radius); y++)
                {
                    Point temp = new Point(x, y);

                    if (Utilities.Distance(temp, cell) <= radius)
                    {
                        double vx, vy;
                        CalVelocity(out vx, out vy, temp, cell, oldCell, strength, FlowMode);
                        Fluid.AddVelocity(x, y, vx, vy);
                    }
                }

            Timer.Start();
        }

        private void CalVelocityForCurlMode(out double x, out double y, Point p, Point center, double strength)
        {
            if(p.X == center.X && p.Y == center.Y)
            {
                x = y = 0;
                return;
            }

            double dist = Utilities.Distance(p, center);
            double angle = Math.Atan2(p.Y - center.Y, p.X - center.X) + Math.PI/2d;

            x = Math.Cos(angle) * strength;
            y = Math.Sin(angle) * strength;
        }

        private void CalVelocityForDivergenceMode(out double x, out double y, Point p, Point center, double strength)
        {
            if(p.X == center.X && p.Y == center.Y)
            {
                x = y = 0;
                return;
            }

            double dist = Utilities.Distance(p, center);
            double angle = Math.Atan2(p.Y - center.Y, p.X - center.X);

            x = Math.Cos(angle) * strength;
            y = Math.Sin(angle) * strength;
        }

        private void CalVelocityForFreeMode(out double x, out double y, Point center, Point oldCenter, double strength)
        {
            x = (center.X - oldCenter.X) * strength;
            y = (center.Y - oldCenter.Y) * strength;
        }

        private void CalVelocity(out double x, out double y, Point p, Point center, Point oldCenter, double strength, FlowModeType flowMode)
        {
            x = 0;
            y = 0;

            switch(flowMode)
            {
                case FlowModeType.Curl:
                    CalVelocityForCurlMode(out x, out y, p, center, strength);
                    return;
                case FlowModeType.Divergence:
                    CalVelocityForDivergenceMode(out x, out y, p, center, strength);
                    return;
                case FlowModeType.Free:
                    CalVelocityForFreeMode(out x, out y, center, oldCenter, strength);
                    return;
                default:
                    throw new Exception("Unknown Flow mode to apply");
            }
        }

        #endregion

        #region User Setting
        private double _dyeAmountToAdd = 1;
        private double DyeAmountToAdd
        {
            get => _dyeAmountToAdd;
            set
            { 
                _dyeAmountToAdd = value;
                numericUpDown_DyeAmount.Value = (decimal)value;
            }
        }

        private double _flowStrengthToAdd = 3000;
        private double FlowStrengthToAdd
        {
            get => _flowStrengthToAdd;
            set
            {
                _flowStrengthToAdd = value;
                numericUpDown_FlowStrength.Value = (decimal)value;
            }
        }


        private bool EnableRenderVelocity
        {
            get => checkBox_ViewVelocity.Checked;
            set => checkBox_ViewVelocity.Checked = value;
        }

        private bool IsPaused
        {
            get => checkBox_Pause.Checked;
            set => checkBox_Pause.Checked = value;
        }

        private bool EnabledHoldMode
        {
            get => checkBox_HoldMode.Checked;
            set => checkBox_HoldMode.Checked = value;
        }

        private Color DyeColor
        {
            get => button_DyeColor.BackColor;
            set
            {
                button_DyeColor.BackColor = value;
                button_DyeColor.ForeColor = Color.FromArgb(255-value.R, 255-value.G, 255-value.B);
            }
        }

        private void InitDefaultSettingValue()
        {
            numericUpDown_Viscosity.Value = (decimal)Fluid.Viscosity;
            numericUpDown_Diffusion.Value = (decimal)Fluid.Diffusion;
            numericUpDown_TimeStep.Value = (decimal)Fluid.TimeStep;
            numericUpDown_Buoyancy.Value = (decimal)Fluid.Buoyancy;
            numericUpDown_Iteration.Value = (decimal)Fluid.Iteration;
            numericUpDown_CursorRadius.Value = (decimal)CursorRadius;
            numericUpDown_DyeAmount.Value = (decimal)DyeAmountToAdd;
            numericUpDown_FlowStrength.Value = (decimal)FlowStrengthToAdd;

            DyeColor = Color.LightPink;
            comboBox_FlowMode.Text = "Free";
        }

        private void numericUpDown_Viscosity_ValueChanged(object sender, EventArgs e)
        {
            Fluid.Viscosity = (double)(sender as NumericUpDown).Value;
        }

        private void numericUpDown_Diffusion_ValueChanged(object sender, EventArgs e)
        {
            Fluid.Diffusion = (double)(sender as NumericUpDown).Value;
        }

        private void numericUpDown_TimeStep_ValueChanged(object sender, EventArgs e)
        {
            Fluid.TimeStep = (double)(sender as NumericUpDown).Value;
        }

        private void numericUpDown_Buoyancy_ValueChanged(object sender, EventArgs e)
        {
            Fluid.Buoyancy = (double)(sender as NumericUpDown).Value;
        }

        private void numericUpDown_Iteration_ValueChanged(object sender, EventArgs e)
        {
            Fluid.Iteration = (int)(sender as NumericUpDown).Value;
        }

        private void numericUpDown_CursorRadius_ValueChanged(object sender, EventArgs e)
        {
            CursorRadius = (double)(sender as NumericUpDown).Value;
        }

        private void button_DyeColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            var dlgRes = dlg.ShowDialog();

            if(dlgRes == DialogResult.OK)
            {
                DyeColor = dlg.Color;
            }
        }

        private void numericUpDown_DyeAmount_ValueChanged(object sender, EventArgs e)
        {
            DyeAmountToAdd = (double)(sender as NumericUpDown).Value;
        }

        private void numericUpDown_FlowStrength_ValueChanged(object sender, EventArgs e)
        {
            FlowStrengthToAdd = (double)(sender as NumericUpDown).Value;
        }
        #endregion

    }
}
