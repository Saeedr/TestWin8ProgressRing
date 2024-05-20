namespace TestWin8ProgressRing
    {
    partial class TestWin8ProgressRing
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
            {
            if ( disposing && ( components != null ) )
                {
                components.Dispose ( );
                }
            base.Dispose ( disposing );
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
            {
            this.start_stop_BUT = new System.Windows.Forms.Button ( );
            this.pulse_BUT = new System.Windows.Forms.Button ( );
            this.panel_background_BUT = new System.Windows.Forms.Button ( );
            this.control_height_LAB = new System.Windows.Forms.Label ( );
            this.control_height_NUD = new System.Windows.Forms.NumericUpDown ( );
            this.panel_background_LAB = new System.Windows.Forms.Label ( );
            this.colors_GB = new System.Windows.Forms.GroupBox ( );
            this.indicator_color_BUT = new System.Windows.Forms.Button ( );
            this.indicator_LAB = new System.Windows.Forms.Label ( );
            this.indicator_type_GB = new System.Windows.Forms.GroupBox ( );
            this.pulsed_RB = new System.Windows.Forms.RadioButton ( );
            this.animated_RB = new System.Windows.Forms.RadioButton ( );
            this.refresh_interval_LAB = new System.Windows.Forms.Label ( );
            this.refresh_interval_NUD = new System.Windows.Forms.NumericUpDown ( );
            this.control_PAN = new System.Windows.Forms.Panel ( );
            this.win8_progress_ring = new Win8ProgressRing.Win8_ProgressRing ( );
            this.exit_BUT = new System.Windows.Forms.Button ( );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.control_height_NUD ) ).BeginInit ( );
            this.colors_GB.SuspendLayout ( );
            this.indicator_type_GB.SuspendLayout ( );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.refresh_interval_NUD ) ).BeginInit ( );
            this.control_PAN.SuspendLayout ( );
            this.SuspendLayout ( );
            // 
            // start_stop_BUT
            // 
            this.start_stop_BUT.BackColor = System.Drawing.SystemColors.Control;
            this.start_stop_BUT.Location = new System.Drawing.Point ( 16, 279 );
            this.start_stop_BUT.Name = "start_stop_BUT";
            this.start_stop_BUT.Size = new System.Drawing.Size ( 75, 25 );
            this.start_stop_BUT.TabIndex = 0;
            this.start_stop_BUT.Tag = "start_stop";
            this.start_stop_BUT.Text = "Stop";
            this.start_stop_BUT.UseVisualStyleBackColor = false;
            this.start_stop_BUT.Click += new System.EventHandler ( this.BUT_Click );
            // 
            // pulse_BUT
            // 
            this.pulse_BUT.BackColor = System.Drawing.SystemColors.Control;
            this.pulse_BUT.Location = new System.Drawing.Point ( 138, 279 );
            this.pulse_BUT.Name = "pulse_BUT";
            this.pulse_BUT.Size = new System.Drawing.Size ( 75, 25 );
            this.pulse_BUT.TabIndex = 1;
            this.pulse_BUT.Tag = "pulse";
            this.pulse_BUT.Text = "Pulse";
            this.pulse_BUT.UseVisualStyleBackColor = false;
            this.pulse_BUT.Click += new System.EventHandler ( this.BUT_Click );
            // 
            // panel_background_BUT
            // 
            this.panel_background_BUT.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_background_BUT.Location = new System.Drawing.Point ( 160, 21 );
            this.panel_background_BUT.Name = "panel_background_BUT";
            this.panel_background_BUT.Size = new System.Drawing.Size ( 25, 25 );
            this.panel_background_BUT.TabIndex = 2;
            this.panel_background_BUT.Tag = "panel_background_color";
            this.panel_background_BUT.UseVisualStyleBackColor = false;
            this.panel_background_BUT.Click += new System.EventHandler ( this.BUT_Click );
            // 
            // control_height_LAB
            // 
            this.control_height_LAB.AutoSize = true;
            this.control_height_LAB.BackColor = System.Drawing.Color.Transparent;
            this.control_height_LAB.Location = new System.Drawing.Point ( 55, 11 );
            this.control_height_LAB.Name = "control_height_LAB";
            this.control_height_LAB.Size = new System.Drawing.Size ( 98, 17 );
            this.control_height_LAB.TabIndex = 4;
            this.control_height_LAB.Text = "Control Height";
            // 
            // control_height_NUD
            // 
            this.control_height_NUD.Location = new System.Drawing.Point ( 160, 8 );
            this.control_height_NUD.Maximum = new decimal ( new int [ ] {
            200,
            0,
            0,
            0} );
            this.control_height_NUD.Minimum = new decimal ( new int [ ] {
            50,
            0,
            0,
            0} );
            this.control_height_NUD.Name = "control_height_NUD";
            this.control_height_NUD.Size = new System.Drawing.Size ( 53, 22 );
            this.control_height_NUD.TabIndex = 5;
            this.control_height_NUD.Tag = "control_height";
            this.control_height_NUD.Value = new decimal ( new int [ ] {
            200,
            0,
            0,
            0} );
            this.control_height_NUD.ValueChanged += new System.EventHandler ( this.NUD_ValueChanged );
            // 
            // panel_background_LAB
            // 
            this.panel_background_LAB.AutoSize = true;
            this.panel_background_LAB.Location = new System.Drawing.Point ( 15, 25 );
            this.panel_background_LAB.Name = "panel_background_LAB";
            this.panel_background_LAB.Size = new System.Drawing.Size ( 124, 17 );
            this.panel_background_LAB.TabIndex = 6;
            this.panel_background_LAB.Text = "Panel Background";
            // 
            // colors_GB
            // 
            this.colors_GB.BackColor = System.Drawing.Color.Transparent;
            this.colors_GB.Controls.Add ( this.indicator_color_BUT );
            this.colors_GB.Controls.Add ( this.indicator_LAB );
            this.colors_GB.Controls.Add ( this.panel_background_BUT );
            this.colors_GB.Controls.Add ( this.panel_background_LAB );
            this.colors_GB.Location = new System.Drawing.Point ( 13, 38 );
            this.colors_GB.Name = "colors_GB";
            this.colors_GB.Size = new System.Drawing.Size ( 200, 92 );
            this.colors_GB.TabIndex = 7;
            this.colors_GB.TabStop = false;
            this.colors_GB.Text = "Colors";
            // 
            // indicator_color_BUT
            // 
            this.indicator_color_BUT.BackColor = System.Drawing.Color.White;
            this.indicator_color_BUT.Location = new System.Drawing.Point ( 160, 55 );
            this.indicator_color_BUT.Name = "indicator_color_BUT";
            this.indicator_color_BUT.Size = new System.Drawing.Size ( 25, 25 );
            this.indicator_color_BUT.TabIndex = 8;
            this.indicator_color_BUT.Tag = "indicator_color";
            this.indicator_color_BUT.UseVisualStyleBackColor = false;
            this.indicator_color_BUT.Click += new System.EventHandler ( this.BUT_Click );
            // 
            // indicator_LAB
            // 
            this.indicator_LAB.AutoSize = true;
            this.indicator_LAB.Location = new System.Drawing.Point ( 77, 59 );
            this.indicator_LAB.Name = "indicator_LAB";
            this.indicator_LAB.Size = new System.Drawing.Size ( 62, 17 );
            this.indicator_LAB.TabIndex = 7;
            this.indicator_LAB.Text = "Indicator";
            // 
            // indicator_type_GB
            // 
            this.indicator_type_GB.BackColor = System.Drawing.Color.Transparent;
            this.indicator_type_GB.Controls.Add ( this.pulsed_RB );
            this.indicator_type_GB.Controls.Add ( this.animated_RB );
            this.indicator_type_GB.Location = new System.Drawing.Point ( 91, 138 );
            this.indicator_type_GB.Name = "indicator_type_GB";
            this.indicator_type_GB.Size = new System.Drawing.Size ( 122, 100 );
            this.indicator_type_GB.TabIndex = 8;
            this.indicator_type_GB.TabStop = false;
            this.indicator_type_GB.Text = "Indicator Type";
            // 
            // pulsed_RB
            // 
            this.pulsed_RB.AutoSize = true;
            this.pulsed_RB.Location = new System.Drawing.Point ( 30, 63 );
            this.pulsed_RB.Name = "pulsed_RB";
            this.pulsed_RB.Size = new System.Drawing.Size ( 69, 21 );
            this.pulsed_RB.TabIndex = 1;
            this.pulsed_RB.Tag = "pulsed";
            this.pulsed_RB.Text = "Pulsed";
            this.pulsed_RB.UseVisualStyleBackColor = true;
            // 
            // animated_RB
            // 
            this.animated_RB.AutoSize = true;
            this.animated_RB.Checked = true;
            this.animated_RB.Location = new System.Drawing.Point ( 30, 29 );
            this.animated_RB.Name = "animated_RB";
            this.animated_RB.Size = new System.Drawing.Size ( 85, 21 );
            this.animated_RB.TabIndex = 0;
            this.animated_RB.TabStop = true;
            this.animated_RB.Tag = "animated";
            this.animated_RB.Text = "Animated";
            this.animated_RB.UseVisualStyleBackColor = true;
            this.animated_RB.CheckedChanged += new System.EventHandler ( this.animated_RB_CheckedChanged );
            // 
            // refresh_interval_LAB
            // 
            this.refresh_interval_LAB.AutoSize = true;
            this.refresh_interval_LAB.Location = new System.Drawing.Point ( 13, 248 );
            this.refresh_interval_LAB.Name = "refresh_interval_LAB";
            this.refresh_interval_LAB.Size = new System.Drawing.Size ( 140, 17 );
            this.refresh_interval_LAB.TabIndex = 9;
            this.refresh_interval_LAB.Text = "Refresh Interval (ms)";
            // 
            // refresh_interval_NUD
            // 
            this.refresh_interval_NUD.AllowDrop = true;
            this.refresh_interval_NUD.Increment = new decimal ( new int [ ] {
            5,
            0,
            0,
            0} );
            this.refresh_interval_NUD.Location = new System.Drawing.Point ( 160, 246 );
            this.refresh_interval_NUD.Maximum = new decimal ( new int [ ] {
            200,
            0,
            0,
            0} );
            this.refresh_interval_NUD.Minimum = new decimal ( new int [ ] {
            10,
            0,
            0,
            0} );
            this.refresh_interval_NUD.Name = "refresh_interval_NUD";
            this.refresh_interval_NUD.Size = new System.Drawing.Size ( 47, 22 );
            this.refresh_interval_NUD.TabIndex = 10;
            this.refresh_interval_NUD.Tag = "refresh_interval";
            this.refresh_interval_NUD.Value = new decimal ( new int [ ] {
            200,
            0,
            0,
            0} );
            this.refresh_interval_NUD.ValueChanged += new System.EventHandler ( this.NUD_ValueChanged );
            // 
            // control_PAN
            // 
            this.control_PAN.BackColor = System.Drawing.Color.RoyalBlue;
            this.control_PAN.Controls.Add ( this.win8_progress_ring );
            this.control_PAN.Location = new System.Drawing.Point ( 227, 49 );
            this.control_PAN.Name = "control_PAN";
            this.control_PAN.Size = new System.Drawing.Size ( 250, 250 );
            this.control_PAN.TabIndex = 11;
            // 
            // win8_progress_ring
            // 
            this.win8_progress_ring.Location = new System.Drawing.Point ( 27, 25 );
            this.win8_progress_ring.Name = "win8_progress_ring";
            this.win8_progress_ring.Refresh_Rate = 100;
            this.win8_progress_ring.Size = new System.Drawing.Size ( 100, 100 );
            this.win8_progress_ring.TabIndex = 3;
            // 
            // exit_BUT
            // 
            this.exit_BUT.BackColor = System.Drawing.SystemColors.Control;
            this.exit_BUT.Location = new System.Drawing.Point ( 401, 314 );
            this.exit_BUT.Name = "exit_BUT";
            this.exit_BUT.Size = new System.Drawing.Size ( 75, 25 );
            this.exit_BUT.TabIndex = 12;
            this.exit_BUT.Tag = "exit";
            this.exit_BUT.Text = "Exit";
            this.exit_BUT.UseVisualStyleBackColor = false;
            this.exit_BUT.Click += new System.EventHandler ( this.BUT_Click );
            // 
            // TestWin8ProgressRing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF ( 8F, 16F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size ( 490, 349 );
            this.Controls.Add ( this.exit_BUT );
            this.Controls.Add ( this.control_PAN );
            this.Controls.Add ( this.refresh_interval_NUD );
            this.Controls.Add ( this.refresh_interval_LAB );
            this.Controls.Add ( this.indicator_type_GB );
            this.Controls.Add ( this.colors_GB );
            this.Controls.Add ( this.control_height_NUD );
            this.Controls.Add ( this.control_height_LAB );
            this.Controls.Add ( this.pulse_BUT );
            this.Controls.Add ( this.start_stop_BUT );
            this.Name = "TestWin8ProgressRing";
            this.Text = "TestWin8ProgressRing";
            ( ( System.ComponentModel.ISupportInitialize ) ( this.control_height_NUD ) ).EndInit ( );
            this.colors_GB.ResumeLayout ( false );
            this.colors_GB.PerformLayout ( );
            this.indicator_type_GB.ResumeLayout ( false );
            this.indicator_type_GB.PerformLayout ( );
            ( ( System.ComponentModel.ISupportInitialize ) ( this.refresh_interval_NUD ) ).EndInit ( );
            this.control_PAN.ResumeLayout ( false );
            this.ResumeLayout ( false );
            this.PerformLayout ( );

            }

        #endregion

        private System.Windows.Forms.Button start_stop_BUT;
        private System.Windows.Forms.Button pulse_BUT;
        private System.Windows.Forms.Button panel_background_BUT;
        private Win8ProgressRing.Win8_ProgressRing win8_progress_ring;
        private System.Windows.Forms.Label control_height_LAB;
        private System.Windows.Forms.NumericUpDown control_height_NUD;
        private System.Windows.Forms.Label panel_background_LAB;
        private System.Windows.Forms.GroupBox colors_GB;
        private System.Windows.Forms.Button indicator_color_BUT;
        private System.Windows.Forms.Label indicator_LAB;
        private System.Windows.Forms.GroupBox indicator_type_GB;
        private System.Windows.Forms.RadioButton pulsed_RB;
        private System.Windows.Forms.RadioButton animated_RB;
        private System.Windows.Forms.Label refresh_interval_LAB;
        private System.Windows.Forms.NumericUpDown refresh_interval_NUD;
        private System.Windows.Forms.Panel control_PAN;
        private System.Windows.Forms.Button exit_BUT;

        }
    }

