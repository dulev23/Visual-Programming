namespace F1Race
{
    partial class Form1
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
            this.gbF1Racer = new System.Windows.Forms.GroupBox();
            this.lbRaceDrivers = new System.Windows.Forms.ListBox();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.gbRaceLaps = new System.Windows.Forms.GroupBox();
            this.btnAddLap = new System.Windows.Forms.Button();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.tbBestLap = new System.Windows.Forms.TextBox();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblBestLap = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.lbRaceLaps = new System.Windows.Forms.ListBox();
            this.btnDeleteDriver = new System.Windows.Forms.Button();
            this.gbF1Racer.SuspendLayout();
            this.gbRaceLaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbF1Racer
            // 
            this.gbF1Racer.Controls.Add(this.lbRaceDrivers);
            this.gbF1Racer.Controls.Add(this.btnAddDriver);
            this.gbF1Racer.Location = new System.Drawing.Point(13, 13);
            this.gbF1Racer.Name = "gbF1Racer";
            this.gbF1Racer.Size = new System.Drawing.Size(372, 598);
            this.gbF1Racer.TabIndex = 0;
            this.gbF1Racer.TabStop = false;
            this.gbF1Racer.Text = "Возачи";
            // 
            // lbRaceDrivers
            // 
            this.lbRaceDrivers.FormattingEnabled = true;
            this.lbRaceDrivers.ItemHeight = 16;
            this.lbRaceDrivers.Location = new System.Drawing.Point(7, 22);
            this.lbRaceDrivers.Name = "lbRaceDrivers";
            this.lbRaceDrivers.Size = new System.Drawing.Size(359, 436);
            this.lbRaceDrivers.TabIndex = 3;
            this.lbRaceDrivers.SelectedIndexChanged += new System.EventHandler(this.lbRaceDrivers_SelectedIndexChanged);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(6, 473);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(360, 52);
            this.btnAddDriver.TabIndex = 2;
            this.btnAddDriver.Text = "Додади возач";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // gbRaceLaps
            // 
            this.gbRaceLaps.Controls.Add(this.btnAddLap);
            this.gbRaceLaps.Controls.Add(this.nudTime);
            this.gbRaceLaps.Controls.Add(this.lblTime);
            this.gbRaceLaps.Controls.Add(this.tbBestLap);
            this.gbRaceLaps.Controls.Add(this.nudSeconds);
            this.gbRaceLaps.Controls.Add(this.lblBestLap);
            this.gbRaceLaps.Controls.Add(this.lblSeconds);
            this.gbRaceLaps.Controls.Add(this.lblMinutes);
            this.gbRaceLaps.Controls.Add(this.nudMinutes);
            this.gbRaceLaps.Controls.Add(this.lbRaceLaps);
            this.gbRaceLaps.Location = new System.Drawing.Point(404, 12);
            this.gbRaceLaps.Name = "gbRaceLaps";
            this.gbRaceLaps.Size = new System.Drawing.Size(396, 600);
            this.gbRaceLaps.TabIndex = 1;
            this.gbRaceLaps.TabStop = false;
            this.gbRaceLaps.Text = "Кругови";
            // 
            // btnAddLap
            // 
            this.btnAddLap.Location = new System.Drawing.Point(262, 362);
            this.btnAddLap.Name = "btnAddLap";
            this.btnAddLap.Size = new System.Drawing.Size(127, 41);
            this.btnAddLap.TabIndex = 9;
            this.btnAddLap.Text = "Додади круг";
            this.btnAddLap.UseVisualStyleBackColor = true;
            this.btnAddLap.Click += new System.EventHandler(this.btnAddLap_Click);
            // 
            // nudTime
            // 
            this.nudTime.Location = new System.Drawing.Point(10, 512);
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(120, 22);
            this.nudTime.TabIndex = 8;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(7, 492);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 16);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Време";
            // 
            // tbBestLap
            // 
            this.tbBestLap.Enabled = false;
            this.tbBestLap.Location = new System.Drawing.Point(6, 437);
            this.tbBestLap.Name = "tbBestLap";
            this.tbBestLap.Size = new System.Drawing.Size(383, 22);
            this.tbBestLap.TabIndex = 6;
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(135, 362);
            this.nudSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(120, 22);
            this.nudSeconds.TabIndex = 5;
            this.nudSeconds.ValueChanged += new System.EventHandler(this.nudSeconds_ValueChanged);
            // 
            // lblBestLap
            // 
            this.lblBestLap.AutoSize = true;
            this.lblBestLap.Location = new System.Drawing.Point(7, 418);
            this.lblBestLap.Name = "lblBestLap";
            this.lblBestLap.Size = new System.Drawing.Size(100, 16);
            this.lblBestLap.TabIndex = 4;
            this.lblBestLap.Text = "Најдобар круг";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(132, 340);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(63, 16);
            this.lblSeconds.TabIndex = 3;
            this.lblSeconds.Text = "Секунди";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(7, 340);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(57, 16);
            this.lblMinutes.TabIndex = 2;
            this.lblMinutes.Text = "Минути";
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(6, 362);
            this.nudMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(120, 22);
            this.nudMinutes.TabIndex = 1;
            // 
            // lbRaceLaps
            // 
            this.lbRaceLaps.FormattingEnabled = true;
            this.lbRaceLaps.ItemHeight = 16;
            this.lbRaceLaps.Location = new System.Drawing.Point(7, 22);
            this.lbRaceLaps.Name = "lbRaceLaps";
            this.lbRaceLaps.Size = new System.Drawing.Size(382, 308);
            this.lbRaceLaps.TabIndex = 0;
            // 
            // btnDeleteDriver
            // 
            this.btnDeleteDriver.Location = new System.Drawing.Point(19, 544);
            this.btnDeleteDriver.Name = "btnDeleteDriver";
            this.btnDeleteDriver.Size = new System.Drawing.Size(360, 50);
            this.btnDeleteDriver.TabIndex = 3;
            this.btnDeleteDriver.Text = "Избриши возач";
            this.btnDeleteDriver.UseVisualStyleBackColor = true;
            this.btnDeleteDriver.Click += new System.EventHandler(this.btnDeleteDriver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 624);
            this.Controls.Add(this.btnDeleteDriver);
            this.Controls.Add(this.gbRaceLaps);
            this.Controls.Add(this.gbF1Racer);
            this.Name = "Form1";
            this.Text = "Ф1 Трка";
            this.gbF1Racer.ResumeLayout(false);
            this.gbRaceLaps.ResumeLayout(false);
            this.gbRaceLaps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbF1Racer;
        private System.Windows.Forms.GroupBox gbRaceLaps;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Button btnDeleteDriver;
        private System.Windows.Forms.ListBox lbRaceDrivers;
        private System.Windows.Forms.ListBox lbRaceLaps;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.TextBox tbBestLap;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.Label lblBestLap;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnAddLap;
    }
}

