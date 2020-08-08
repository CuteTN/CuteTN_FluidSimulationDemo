namespace NavierStokes_FluidSimulation
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_General = new System.Windows.Forms.Label();
            this.label_Viscosity = new System.Windows.Forms.Label();
            this.label_Diffusion = new System.Windows.Forms.Label();
            this.label_TimeStep = new System.Windows.Forms.Label();
            this.label_Buoyancy = new System.Windows.Forms.Label();
            this.label_Iteration = new System.Windows.Forms.Label();
            this.numericUpDown_Viscosity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Diffusion = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_TimeStep = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Buoyancy = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Iteration = new System.Windows.Forms.NumericUpDown();
            this.label_ViewVelocity = new System.Windows.Forms.Label();
            this.checkBox_ViewVelocity = new System.Windows.Forms.CheckBox();
            this.label_Pause = new System.Windows.Forms.Label();
            this.checkBox_Pause = new System.Windows.Forms.CheckBox();
            this.label_CursorRadius = new System.Windows.Forms.Label();
            this.numericUpDown_CursorRadius = new System.Windows.Forms.NumericUpDown();
            this.label_Dye = new System.Windows.Forms.Label();
            this.label_DyeColor = new System.Windows.Forms.Label();
            this.button_DyeColor = new System.Windows.Forms.Button();
            this.label_DyeAmount = new System.Windows.Forms.Label();
            this.numericUpDown_DyeAmount = new System.Windows.Forms.NumericUpDown();
            this.label_Flow = new System.Windows.Forms.Label();
            this.label_FlowMode = new System.Windows.Forms.Label();
            this.comboBox_FlowMode = new System.Windows.Forms.ComboBox();
            this.label_FlowStrength = new System.Windows.Forms.Label();
            this.numericUpDown_FlowStrength = new System.Windows.Forms.NumericUpDown();
            this.checkBox_HoldMode = new System.Windows.Forms.CheckBox();
            this.label_HoldMode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Viscosity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Diffusion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TimeStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Buoyancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Iteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CursorRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DyeAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FlowStrength)).BeginInit();
            this.SuspendLayout();
            // 
            // label_General
            // 
            this.label_General.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_General.AutoSize = true;
            this.label_General.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_General.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_General.Location = new System.Drawing.Point(420, 10);
            this.label_General.Name = "label_General";
            this.label_General.Size = new System.Drawing.Size(118, 38);
            this.label_General.TabIndex = 0;
            this.label_General.Text = "General";
            // 
            // label_Viscosity
            // 
            this.label_Viscosity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Viscosity.AutoSize = true;
            this.label_Viscosity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Viscosity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_Viscosity.Location = new System.Drawing.Point(440, 70);
            this.label_Viscosity.Name = "label_Viscosity";
            this.label_Viscosity.Size = new System.Drawing.Size(79, 23);
            this.label_Viscosity.TabIndex = 1;
            this.label_Viscosity.Text = "Viscosity";
            // 
            // label_Diffusion
            // 
            this.label_Diffusion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Diffusion.AutoSize = true;
            this.label_Diffusion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Diffusion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_Diffusion.Location = new System.Drawing.Point(440, 110);
            this.label_Diffusion.Name = "label_Diffusion";
            this.label_Diffusion.Size = new System.Drawing.Size(84, 23);
            this.label_Diffusion.TabIndex = 2;
            this.label_Diffusion.Text = "Diffusion";
            // 
            // label_TimeStep
            // 
            this.label_TimeStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_TimeStep.AutoSize = true;
            this.label_TimeStep.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimeStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_TimeStep.Location = new System.Drawing.Point(440, 150);
            this.label_TimeStep.Name = "label_TimeStep";
            this.label_TimeStep.Size = new System.Drawing.Size(92, 23);
            this.label_TimeStep.TabIndex = 3;
            this.label_TimeStep.Text = "Time Step";
            // 
            // label_Buoyancy
            // 
            this.label_Buoyancy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Buoyancy.AutoSize = true;
            this.label_Buoyancy.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Buoyancy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_Buoyancy.Location = new System.Drawing.Point(440, 190);
            this.label_Buoyancy.Name = "label_Buoyancy";
            this.label_Buoyancy.Size = new System.Drawing.Size(86, 23);
            this.label_Buoyancy.TabIndex = 4;
            this.label_Buoyancy.Text = "Buoyancy";
            // 
            // label_Iteration
            // 
            this.label_Iteration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Iteration.AutoSize = true;
            this.label_Iteration.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Iteration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_Iteration.Location = new System.Drawing.Point(440, 230);
            this.label_Iteration.Name = "label_Iteration";
            this.label_Iteration.Size = new System.Drawing.Size(79, 23);
            this.label_Iteration.TabIndex = 5;
            this.label_Iteration.Text = "Iteration";
            // 
            // numericUpDown_Viscosity
            // 
            this.numericUpDown_Viscosity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_Viscosity.DecimalPlaces = 9;
            this.numericUpDown_Viscosity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Viscosity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_Viscosity.Location = new System.Drawing.Point(580, 70);
            this.numericUpDown_Viscosity.Name = "numericUpDown_Viscosity";
            this.numericUpDown_Viscosity.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown_Viscosity.TabIndex = 6;
            this.numericUpDown_Viscosity.ValueChanged += new System.EventHandler(this.numericUpDown_Viscosity_ValueChanged);
            // 
            // numericUpDown_Diffusion
            // 
            this.numericUpDown_Diffusion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_Diffusion.DecimalPlaces = 9;
            this.numericUpDown_Diffusion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Diffusion.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_Diffusion.Location = new System.Drawing.Point(580, 110);
            this.numericUpDown_Diffusion.Name = "numericUpDown_Diffusion";
            this.numericUpDown_Diffusion.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown_Diffusion.TabIndex = 7;
            this.numericUpDown_Diffusion.ValueChanged += new System.EventHandler(this.numericUpDown_Diffusion_ValueChanged);
            // 
            // numericUpDown_TimeStep
            // 
            this.numericUpDown_TimeStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_TimeStep.DecimalPlaces = 9;
            this.numericUpDown_TimeStep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_TimeStep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.numericUpDown_TimeStep.Location = new System.Drawing.Point(580, 150);
            this.numericUpDown_TimeStep.Name = "numericUpDown_TimeStep";
            this.numericUpDown_TimeStep.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown_TimeStep.TabIndex = 8;
            this.numericUpDown_TimeStep.ValueChanged += new System.EventHandler(this.numericUpDown_TimeStep_ValueChanged);
            // 
            // numericUpDown_Buoyancy
            // 
            this.numericUpDown_Buoyancy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_Buoyancy.DecimalPlaces = 9;
            this.numericUpDown_Buoyancy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Buoyancy.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_Buoyancy.Location = new System.Drawing.Point(580, 190);
            this.numericUpDown_Buoyancy.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Buoyancy.Name = "numericUpDown_Buoyancy";
            this.numericUpDown_Buoyancy.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown_Buoyancy.TabIndex = 9;
            this.numericUpDown_Buoyancy.ValueChanged += new System.EventHandler(this.numericUpDown_Buoyancy_ValueChanged);
            // 
            // numericUpDown_Iteration
            // 
            this.numericUpDown_Iteration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_Iteration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Iteration.Location = new System.Drawing.Point(580, 230);
            this.numericUpDown_Iteration.Name = "numericUpDown_Iteration";
            this.numericUpDown_Iteration.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown_Iteration.TabIndex = 10;
            this.numericUpDown_Iteration.ValueChanged += new System.EventHandler(this.numericUpDown_Iteration_ValueChanged);
            // 
            // label_ViewVelocity
            // 
            this.label_ViewVelocity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ViewVelocity.AutoSize = true;
            this.label_ViewVelocity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ViewVelocity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_ViewVelocity.Location = new System.Drawing.Point(440, 270);
            this.label_ViewVelocity.Name = "label_ViewVelocity";
            this.label_ViewVelocity.Size = new System.Drawing.Size(117, 23);
            this.label_ViewVelocity.TabIndex = 11;
            this.label_ViewVelocity.Text = "View Velocity";
            // 
            // checkBox_ViewVelocity
            // 
            this.checkBox_ViewVelocity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_ViewVelocity.AutoSize = true;
            this.checkBox_ViewVelocity.Location = new System.Drawing.Point(580, 270);
            this.checkBox_ViewVelocity.Name = "checkBox_ViewVelocity";
            this.checkBox_ViewVelocity.Size = new System.Drawing.Size(98, 21);
            this.checkBox_ViewVelocity.TabIndex = 12;
            this.checkBox_ViewVelocity.Text = "checkBox1";
            this.checkBox_ViewVelocity.UseVisualStyleBackColor = true;
            // 
            // label_Pause
            // 
            this.label_Pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Pause.AutoSize = true;
            this.label_Pause.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_Pause.Location = new System.Drawing.Point(440, 310);
            this.label_Pause.Name = "label_Pause";
            this.label_Pause.Size = new System.Drawing.Size(55, 23);
            this.label_Pause.TabIndex = 13;
            this.label_Pause.Text = "Pause";
            // 
            // checkBox_Pause
            // 
            this.checkBox_Pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_Pause.AutoSize = true;
            this.checkBox_Pause.Location = new System.Drawing.Point(580, 310);
            this.checkBox_Pause.Name = "checkBox_Pause";
            this.checkBox_Pause.Size = new System.Drawing.Size(98, 21);
            this.checkBox_Pause.TabIndex = 14;
            this.checkBox_Pause.Text = "checkBox1";
            this.checkBox_Pause.UseVisualStyleBackColor = true;
            // 
            // label_CursorRadius
            // 
            this.label_CursorRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CursorRadius.AutoSize = true;
            this.label_CursorRadius.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CursorRadius.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_CursorRadius.Location = new System.Drawing.Point(440, 350);
            this.label_CursorRadius.Name = "label_CursorRadius";
            this.label_CursorRadius.Size = new System.Drawing.Size(120, 23);
            this.label_CursorRadius.TabIndex = 15;
            this.label_CursorRadius.Text = "Cursor Radius";
            // 
            // numericUpDown_CursorRadius
            // 
            this.numericUpDown_CursorRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_CursorRadius.DecimalPlaces = 2;
            this.numericUpDown_CursorRadius.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_CursorRadius.Location = new System.Drawing.Point(580, 350);
            this.numericUpDown_CursorRadius.Name = "numericUpDown_CursorRadius";
            this.numericUpDown_CursorRadius.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown_CursorRadius.TabIndex = 16;
            this.numericUpDown_CursorRadius.ValueChanged += new System.EventHandler(this.numericUpDown_CursorRadius_ValueChanged);
            // 
            // label_Dye
            // 
            this.label_Dye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Dye.AutoSize = true;
            this.label_Dye.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_Dye.Location = new System.Drawing.Point(420, 440);
            this.label_Dye.Name = "label_Dye";
            this.label_Dye.Size = new System.Drawing.Size(244, 38);
            this.label_Dye.TabIndex = 17;
            this.label_Dye.Text = "Dye (Left Mouse)";
            // 
            // label_DyeColor
            // 
            this.label_DyeColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_DyeColor.AutoSize = true;
            this.label_DyeColor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DyeColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_DyeColor.Location = new System.Drawing.Point(440, 500);
            this.label_DyeColor.Name = "label_DyeColor";
            this.label_DyeColor.Size = new System.Drawing.Size(89, 23);
            this.label_DyeColor.TabIndex = 18;
            this.label_DyeColor.Text = "Dye Color";
            // 
            // button_DyeColor
            // 
            this.button_DyeColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DyeColor.Location = new System.Drawing.Point(580, 500);
            this.button_DyeColor.Name = "button_DyeColor";
            this.button_DyeColor.Size = new System.Drawing.Size(120, 27);
            this.button_DyeColor.TabIndex = 19;
            this.button_DyeColor.Text = "choose";
            this.button_DyeColor.UseVisualStyleBackColor = true;
            this.button_DyeColor.Click += new System.EventHandler(this.button_DyeColor_Click);
            // 
            // label_DyeAmount
            // 
            this.label_DyeAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_DyeAmount.AutoSize = true;
            this.label_DyeAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DyeAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_DyeAmount.Location = new System.Drawing.Point(440, 540);
            this.label_DyeAmount.Name = "label_DyeAmount";
            this.label_DyeAmount.Size = new System.Drawing.Size(111, 23);
            this.label_DyeAmount.TabIndex = 20;
            this.label_DyeAmount.Text = "Dye Amount";
            // 
            // numericUpDown_DyeAmount
            // 
            this.numericUpDown_DyeAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_DyeAmount.DecimalPlaces = 9;
            this.numericUpDown_DyeAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_DyeAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_DyeAmount.Location = new System.Drawing.Point(580, 540);
            this.numericUpDown_DyeAmount.Name = "numericUpDown_DyeAmount";
            this.numericUpDown_DyeAmount.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown_DyeAmount.TabIndex = 21;
            this.numericUpDown_DyeAmount.ValueChanged += new System.EventHandler(this.numericUpDown_DyeAmount_ValueChanged);
            // 
            // label_Flow
            // 
            this.label_Flow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Flow.AutoSize = true;
            this.label_Flow.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Flow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_Flow.Location = new System.Drawing.Point(420, 590);
            this.label_Flow.Name = "label_Flow";
            this.label_Flow.Size = new System.Drawing.Size(280, 38);
            this.label_Flow.TabIndex = 22;
            this.label_Flow.Text = "FLow (Right Mouse)";
            // 
            // label_FlowMode
            // 
            this.label_FlowMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FlowMode.AutoSize = true;
            this.label_FlowMode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FlowMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_FlowMode.Location = new System.Drawing.Point(440, 650);
            this.label_FlowMode.Name = "label_FlowMode";
            this.label_FlowMode.Size = new System.Drawing.Size(99, 23);
            this.label_FlowMode.TabIndex = 23;
            this.label_FlowMode.Text = "Flow Mode";
            // 
            // comboBox_FlowMode
            // 
            this.comboBox_FlowMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_FlowMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_FlowMode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBox_FlowMode.FormattingEnabled = true;
            this.comboBox_FlowMode.Items.AddRange(new object[] {
            "Curl",
            "Divergence",
            "Free"});
            this.comboBox_FlowMode.Location = new System.Drawing.Point(580, 650);
            this.comboBox_FlowMode.Name = "comboBox_FlowMode";
            this.comboBox_FlowMode.Size = new System.Drawing.Size(120, 28);
            this.comboBox_FlowMode.TabIndex = 24;
            // 
            // label_FlowStrength
            // 
            this.label_FlowStrength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_FlowStrength.AutoSize = true;
            this.label_FlowStrength.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FlowStrength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_FlowStrength.Location = new System.Drawing.Point(440, 690);
            this.label_FlowStrength.Name = "label_FlowStrength";
            this.label_FlowStrength.Size = new System.Drawing.Size(124, 23);
            this.label_FlowStrength.TabIndex = 25;
            this.label_FlowStrength.Text = "Flow Strength";
            // 
            // numericUpDown_FlowStrength
            // 
            this.numericUpDown_FlowStrength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_FlowStrength.DecimalPlaces = 9;
            this.numericUpDown_FlowStrength.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_FlowStrength.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_FlowStrength.Location = new System.Drawing.Point(580, 690);
            this.numericUpDown_FlowStrength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_FlowStrength.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDown_FlowStrength.Name = "numericUpDown_FlowStrength";
            this.numericUpDown_FlowStrength.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown_FlowStrength.TabIndex = 26;
            this.numericUpDown_FlowStrength.ValueChanged += new System.EventHandler(this.numericUpDown_FlowStrength_ValueChanged);
            // 
            // checkBox_HoldMode
            // 
            this.checkBox_HoldMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_HoldMode.AutoSize = true;
            this.checkBox_HoldMode.Location = new System.Drawing.Point(580, 390);
            this.checkBox_HoldMode.Name = "checkBox_HoldMode";
            this.checkBox_HoldMode.Size = new System.Drawing.Size(98, 21);
            this.checkBox_HoldMode.TabIndex = 28;
            this.checkBox_HoldMode.Text = "checkBox1";
            this.checkBox_HoldMode.UseVisualStyleBackColor = true;
            // 
            // label_HoldMode
            // 
            this.label_HoldMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_HoldMode.AutoSize = true;
            this.label_HoldMode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HoldMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_HoldMode.Location = new System.Drawing.Point(440, 390);
            this.label_HoldMode.Name = "label_HoldMode";
            this.label_HoldMode.Size = new System.Drawing.Size(100, 23);
            this.label_HoldMode.TabIndex = 27;
            this.label_HoldMode.Text = "Hold Mode";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 795);
            this.Controls.Add(this.checkBox_HoldMode);
            this.Controls.Add(this.label_HoldMode);
            this.Controls.Add(this.numericUpDown_FlowStrength);
            this.Controls.Add(this.label_FlowStrength);
            this.Controls.Add(this.comboBox_FlowMode);
            this.Controls.Add(this.label_FlowMode);
            this.Controls.Add(this.label_Flow);
            this.Controls.Add(this.numericUpDown_DyeAmount);
            this.Controls.Add(this.label_DyeAmount);
            this.Controls.Add(this.button_DyeColor);
            this.Controls.Add(this.label_DyeColor);
            this.Controls.Add(this.label_Dye);
            this.Controls.Add(this.numericUpDown_CursorRadius);
            this.Controls.Add(this.label_CursorRadius);
            this.Controls.Add(this.checkBox_Pause);
            this.Controls.Add(this.label_Pause);
            this.Controls.Add(this.checkBox_ViewVelocity);
            this.Controls.Add(this.label_ViewVelocity);
            this.Controls.Add(this.numericUpDown_Iteration);
            this.Controls.Add(this.numericUpDown_Buoyancy);
            this.Controls.Add(this.numericUpDown_TimeStep);
            this.Controls.Add(this.numericUpDown_Diffusion);
            this.Controls.Add(this.numericUpDown_Viscosity);
            this.Controls.Add(this.label_Iteration);
            this.Controls.Add(this.label_Buoyancy);
            this.Controls.Add(this.label_TimeStep);
            this.Controls.Add(this.label_Diffusion);
            this.Controls.Add(this.label_Viscosity);
            this.Controls.Add(this.label_General);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "CuteTN_NavierStokeSimulation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormMain_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Viscosity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Diffusion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TimeStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Buoyancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Iteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CursorRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DyeAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FlowStrength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_General;
        private System.Windows.Forms.Label label_Viscosity;
        private System.Windows.Forms.Label label_Diffusion;
        private System.Windows.Forms.Label label_TimeStep;
        private System.Windows.Forms.Label label_Buoyancy;
        private System.Windows.Forms.Label label_Iteration;
        private System.Windows.Forms.NumericUpDown numericUpDown_Viscosity;
        private System.Windows.Forms.NumericUpDown numericUpDown_Diffusion;
        private System.Windows.Forms.NumericUpDown numericUpDown_TimeStep;
        private System.Windows.Forms.NumericUpDown numericUpDown_Buoyancy;
        private System.Windows.Forms.NumericUpDown numericUpDown_Iteration;
        private System.Windows.Forms.Label label_ViewVelocity;
        private System.Windows.Forms.CheckBox checkBox_ViewVelocity;
        private System.Windows.Forms.Label label_Pause;
        private System.Windows.Forms.CheckBox checkBox_Pause;
        private System.Windows.Forms.Label label_CursorRadius;
        private System.Windows.Forms.NumericUpDown numericUpDown_CursorRadius;
        private System.Windows.Forms.Label label_Dye;
        private System.Windows.Forms.Label label_DyeColor;
        private System.Windows.Forms.Button button_DyeColor;
        private System.Windows.Forms.Label label_DyeAmount;
        private System.Windows.Forms.NumericUpDown numericUpDown_DyeAmount;
        private System.Windows.Forms.Label label_Flow;
        private System.Windows.Forms.Label label_FlowMode;
        private System.Windows.Forms.ComboBox comboBox_FlowMode;
        private System.Windows.Forms.Label label_FlowStrength;
        private System.Windows.Forms.NumericUpDown numericUpDown_FlowStrength;
        private System.Windows.Forms.CheckBox checkBox_HoldMode;
        private System.Windows.Forms.Label label_HoldMode;
    }
}

