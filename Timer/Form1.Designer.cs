namespace Timer
{
    partial class Timer
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
            this.Start = new System.Windows.Forms.Button();
            this.Lap = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Laps = new System.Windows.Forms.FlowLayoutPanel();
            this.LapInstance = new System.Windows.Forms.Label();
            this.TimerWindow = new System.Windows.Forms.Label();
            this.Stoper_Panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer_layout_button = new System.Windows.Forms.Button();
            this.stopper_layout_button = new System.Windows.Forms.Button();
            this.Timer_Panel = new System.Windows.Forms.Panel();
            this.TimerWatchFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.Hours_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Minutes_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Seconds_textbox = new System.Windows.Forms.TextBox();
            this.Timer_start_button = new System.Windows.Forms.Button();
            this.Timer_reset_button = new System.Windows.Forms.Button();
            this.ProgressBar = new CircularProgressBar();
            this.Laps.SuspendLayout();
            this.Stoper_Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Timer_Panel.SuspendLayout();
            this.TimerWatchFLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.BackColor = System.Drawing.Color.Green;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.Black;
            this.Start.Location = new System.Drawing.Point(225, 187);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 37);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Lap
            // 
            this.Lap.AutoSize = true;
            this.Lap.BackColor = System.Drawing.Color.SandyBrown;
            this.Lap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lap.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lap.ForeColor = System.Drawing.Color.Black;
            this.Lap.Location = new System.Drawing.Point(225, 243);
            this.Lap.Name = "Lap";
            this.Lap.Size = new System.Drawing.Size(75, 37);
            this.Lap.TabIndex = 2;
            this.Lap.Text = "Lap";
            this.Lap.UseVisualStyleBackColor = false;
            this.Lap.Click += new System.EventHandler(this.Lap_Click);
            // 
            // Reset
            // 
            this.Reset.AutoSize = true;
            this.Reset.BackColor = System.Drawing.Color.Red;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Reset.ForeColor = System.Drawing.Color.Black;
            this.Reset.Location = new System.Drawing.Point(225, 298);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 37);
            this.Reset.TabIndex = 3;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Laps
            // 
            this.Laps.AutoScroll = true;
            this.Laps.BackColor = System.Drawing.Color.Transparent;
            this.Laps.Controls.Add(this.LapInstance);
            this.Laps.Location = new System.Drawing.Point(330, 9);
            this.Laps.Name = "Laps";
            this.Laps.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Laps.Size = new System.Drawing.Size(200, 339);
            this.Laps.TabIndex = 4;
            // 
            // LapInstance
            // 
            this.LapInstance.AutoSize = true;
            this.LapInstance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LapInstance.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LapInstance.Location = new System.Drawing.Point(80, 0);
            this.LapInstance.Name = "LapInstance";
            this.LapInstance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LapInstance.Size = new System.Drawing.Size(117, 17);
            this.LapInstance.TabIndex = 0;
            this.LapInstance.Text = "1.  00:00:00.00";
            // 
            // TimerWindow
            // 
            this.TimerWindow.AutoSize = true;
            this.TimerWindow.BackColor = System.Drawing.Color.Transparent;
            this.TimerWindow.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerWindow.ForeColor = System.Drawing.Color.MediumPurple;
            this.TimerWindow.Location = new System.Drawing.Point(204, 9);
            this.TimerWindow.Name = "TimerWindow";
            this.TimerWindow.Size = new System.Drawing.Size(120, 20);
            this.TimerWindow.TabIndex = 5;
            this.TimerWindow.Text = "00:00:00.00";
            // 
            // Stoper_Panel
            // 
            this.Stoper_Panel.AutoSize = true;
            this.Stoper_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Stoper_Panel.Controls.Add(this.TimerWindow);
            this.Stoper_Panel.Controls.Add(this.Start);
            this.Stoper_Panel.Controls.Add(this.Laps);
            this.Stoper_Panel.Controls.Add(this.Lap);
            this.Stoper_Panel.Controls.Add(this.Reset);
            this.Stoper_Panel.Enabled = false;
            this.Stoper_Panel.Location = new System.Drawing.Point(3, 3);
            this.Stoper_Panel.Name = "Stoper_Panel";
            this.Stoper_Panel.Size = new System.Drawing.Size(542, 360);
            this.Stoper_Panel.TabIndex = 6;
            this.Stoper_Panel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.timer_layout_button);
            this.panel1.Controls.Add(this.stopper_layout_button);
            this.panel1.Location = new System.Drawing.Point(3, 367);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 53);
            this.panel1.TabIndex = 0;
            // 
            // timer_layout_button
            // 
            this.timer_layout_button.AutoSize = true;
            this.timer_layout_button.BackColor = System.Drawing.Color.Transparent;
            this.timer_layout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timer_layout_button.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.timer_layout_button.ForeColor = System.Drawing.Color.MediumOrchid;
            this.timer_layout_button.Location = new System.Drawing.Point(185, 14);
            this.timer_layout_button.Name = "timer_layout_button";
            this.timer_layout_button.Size = new System.Drawing.Size(75, 28);
            this.timer_layout_button.TabIndex = 0;
            this.timer_layout_button.Text = "Timer";
            this.timer_layout_button.UseVisualStyleBackColor = false;
            this.timer_layout_button.Click += new System.EventHandler(this.timer_layout_button_Click);
            // 
            // stopper_layout_button
            // 
            this.stopper_layout_button.AutoSize = true;
            this.stopper_layout_button.BackColor = System.Drawing.Color.Peru;
            this.stopper_layout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopper_layout_button.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.stopper_layout_button.ForeColor = System.Drawing.Color.Black;
            this.stopper_layout_button.Location = new System.Drawing.Point(266, 14);
            this.stopper_layout_button.Name = "stopper_layout_button";
            this.stopper_layout_button.Size = new System.Drawing.Size(75, 28);
            this.stopper_layout_button.TabIndex = 0;
            this.stopper_layout_button.Text = "Stopper";
            this.stopper_layout_button.UseVisualStyleBackColor = false;
            this.stopper_layout_button.Click += new System.EventHandler(this.stopper_button_click);
            // 
            // Timer_Panel
            // 
            this.Timer_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Timer_Panel.Controls.Add(this.TimerWatchFLP);
            this.Timer_Panel.Controls.Add(this.Timer_start_button);
            this.Timer_Panel.Controls.Add(this.Stoper_Panel);
            this.Timer_Panel.Controls.Add(this.ProgressBar);
            this.Timer_Panel.Controls.Add(this.Timer_reset_button);
            this.Timer_Panel.Enabled = false;
            this.Timer_Panel.Location = new System.Drawing.Point(3, 1);
            this.Timer_Panel.Name = "Timer_Panel";
            this.Timer_Panel.Size = new System.Drawing.Size(542, 360);
            this.Timer_Panel.TabIndex = 0;
            this.Timer_Panel.Visible = false;
            // 
            // TimerWatchFLP
            // 
            this.TimerWatchFLP.AutoSize = true;
            this.TimerWatchFLP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TimerWatchFLP.Controls.Add(this.Hours_textbox);
            this.TimerWatchFLP.Controls.Add(this.label2);
            this.TimerWatchFLP.Controls.Add(this.Minutes_textbox);
            this.TimerWatchFLP.Controls.Add(this.label1);
            this.TimerWatchFLP.Controls.Add(this.Seconds_textbox);
            this.TimerWatchFLP.Location = new System.Drawing.Point(225, 172);
            this.TimerWatchFLP.Margin = new System.Windows.Forms.Padding(0);
            this.TimerWatchFLP.Name = "TimerWatchFLP";
            this.TimerWatchFLP.Size = new System.Drawing.Size(93, 20);
            this.TimerWatchFLP.TabIndex = 11;
            // 
            // Hours_textbox
            // 
            this.Hours_textbox.BackColor = System.Drawing.Color.Black;
            this.Hours_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Hours_textbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Hours_textbox.ForeColor = System.Drawing.Color.MediumPurple;
            this.Hours_textbox.Location = new System.Drawing.Point(0, 0);
            this.Hours_textbox.Margin = new System.Windows.Forms.Padding(0);
            this.Hours_textbox.Name = "Hours_textbox";
            this.Hours_textbox.Size = new System.Drawing.Size(24, 20);
            this.Hours_textbox.TabIndex = 1;
            this.Hours_textbox.Text = "00";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumPurple;
            this.label2.Location = new System.Drawing.Point(24, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Minutes_textbox
            // 
            this.Minutes_textbox.BackColor = System.Drawing.Color.Black;
            this.Minutes_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Minutes_textbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Minutes_textbox.ForeColor = System.Drawing.Color.MediumPurple;
            this.Minutes_textbox.Location = new System.Drawing.Point(34, 0);
            this.Minutes_textbox.Margin = new System.Windows.Forms.Padding(0);
            this.Minutes_textbox.Name = "Minutes_textbox";
            this.Minutes_textbox.Size = new System.Drawing.Size(24, 20);
            this.Minutes_textbox.TabIndex = 2;
            this.Minutes_textbox.Text = "00";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(58, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = ":";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Seconds_textbox
            // 
            this.Seconds_textbox.BackColor = System.Drawing.Color.Black;
            this.Seconds_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Seconds_textbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Seconds_textbox.ForeColor = System.Drawing.Color.MediumPurple;
            this.Seconds_textbox.Location = new System.Drawing.Point(69, 0);
            this.Seconds_textbox.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.Seconds_textbox.Name = "Seconds_textbox";
            this.Seconds_textbox.Size = new System.Drawing.Size(24, 20);
            this.Seconds_textbox.TabIndex = 3;
            this.Seconds_textbox.Text = "00";
            // 
            // Timer_start_button
            // 
            this.Timer_start_button.AutoSize = true;
            this.Timer_start_button.BackColor = System.Drawing.Color.Green;
            this.Timer_start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Timer_start_button.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer_start_button.ForeColor = System.Drawing.Color.Black;
            this.Timer_start_button.Location = new System.Drawing.Point(185, 299);
            this.Timer_start_button.Name = "Timer_start_button";
            this.Timer_start_button.Size = new System.Drawing.Size(75, 37);
            this.Timer_start_button.TabIndex = 4;
            this.Timer_start_button.Text = "Start";
            this.Timer_start_button.UseVisualStyleBackColor = false;
            this.Timer_start_button.Click += new System.EventHandler(this.Timer_start_button_Click);
            // 
            // Timer_reset_button
            // 
            this.Timer_reset_button.AutoSize = true;
            this.Timer_reset_button.BackColor = System.Drawing.Color.Red;
            this.Timer_reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Timer_reset_button.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Timer_reset_button.ForeColor = System.Drawing.Color.Black;
            this.Timer_reset_button.Location = new System.Drawing.Point(266, 299);
            this.Timer_reset_button.Name = "Timer_reset_button";
            this.Timer_reset_button.Size = new System.Drawing.Size(75, 37);
            this.Timer_reset_button.TabIndex = 5;
            this.Timer_reset_button.Text = "Reset";
            this.Timer_reset_button.UseVisualStyleBackColor = false;
            this.Timer_reset_button.Click += new System.EventHandler(this.Timer_reset_button_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar.BarColor1 = System.Drawing.Color.Transparent;
            this.ProgressBar.BarColor2 = System.Drawing.Color.MediumOrchid;
            this.ProgressBar.BarWidth = 10F;
            this.ProgressBar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBar.ForeColor = System.Drawing.Color.DarkRed;
            this.ProgressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.ProgressBar.LineColor = System.Drawing.Color.Transparent;
            this.ProgressBar.LineWidth = 10;
            this.ProgressBar.Location = new System.Drawing.Point(144, 56);
            this.ProgressBar.Maximum = ((long)(100));
            this.ProgressBar.MinimumSize = new System.Drawing.Size(100, 100);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressShape = CircularProgressBar._ProgressShape.Round;
            this.ProgressBar.Size = new System.Drawing.Size(237, 237);
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.TextMode = CircularProgressBar._TextMode.None;
            this.ProgressBar.Value = ((long)(25));
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 421);
            this.Controls.Add(this.Timer_Panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Timer";
            this.Text = "Timer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Timer_FormClosed);
            this.Load += new System.EventHandler(this.Timer_Load);
            this.Laps.ResumeLayout(false);
            this.Laps.PerformLayout();
            this.Stoper_Panel.ResumeLayout(false);
            this.Stoper_Panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Timer_Panel.ResumeLayout(false);
            this.Timer_Panel.PerformLayout();
            this.TimerWatchFLP.ResumeLayout(false);
            this.TimerWatchFLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Lap;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label LapInstance;
        private System.Windows.Forms.Label TimerWindow;
        private System.Windows.Forms.FlowLayoutPanel Laps;
        private System.Windows.Forms.Panel Stoper_Panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button timer_layout_button;
        private System.Windows.Forms.Button stopper_layout_button;
        private System.Windows.Forms.Panel Timer_Panel;
        private System.Windows.Forms.Button Timer_start_button;
        private System.Windows.Forms.Button Timer_reset_button;
        private System.Windows.Forms.TextBox Minutes_textbox;
        private System.Windows.Forms.FlowLayoutPanel TimerWatchFLP;
        private System.Windows.Forms.TextBox Hours_textbox;
        private System.Windows.Forms.TextBox Seconds_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CircularProgressBar ProgressBar;
    }
}

