namespace Airplane
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
            this.lblAirport = new System.Windows.Forms.Label();
            this.lbAirports = new System.Windows.Forms.ListBox();
            this.lbDestinations = new System.Windows.Forms.ListBox();
            this.lblDestinations = new System.Windows.Forms.Label();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.gbDestination = new System.Windows.Forms.GroupBox();
            this.tbAverageDestLength = new System.Windows.Forms.TextBox();
            this.tbMostExpensiveDest = new System.Windows.Forms.TextBox();
            this.lblAverageLength = new System.Windows.Forms.Label();
            this.lblMostExpensiveDest = new System.Windows.Forms.Label();
            this.gbDestination.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAirport
            // 
            this.lblAirport.AutoSize = true;
            this.lblAirport.Location = new System.Drawing.Point(13, 13);
            this.lblAirport.Name = "lblAirport";
            this.lblAirport.Size = new System.Drawing.Size(81, 16);
            this.lblAirport.TabIndex = 0;
            this.lblAirport.Text = "Аеродроми";
            // 
            // lbAirports
            // 
            this.lbAirports.FormattingEnabled = true;
            this.lbAirports.ItemHeight = 16;
            this.lbAirports.Location = new System.Drawing.Point(16, 33);
            this.lbAirports.Name = "lbAirports";
            this.lbAirports.Size = new System.Drawing.Size(319, 276);
            this.lbAirports.TabIndex = 1;
            this.lbAirports.SelectedIndexChanged += new System.EventHandler(this.lbAirports_SelectedIndexChanged);
            // 
            // lbDestinations
            // 
            this.lbDestinations.FormattingEnabled = true;
            this.lbDestinations.ItemHeight = 16;
            this.lbDestinations.Location = new System.Drawing.Point(341, 33);
            this.lbDestinations.Name = "lbDestinations";
            this.lbDestinations.Size = new System.Drawing.Size(319, 276);
            this.lbDestinations.TabIndex = 2;
            // 
            // lblDestinations
            // 
            this.lblDestinations.AutoSize = true;
            this.lblDestinations.Location = new System.Drawing.Point(338, 9);
            this.lblDestinations.Name = "lblDestinations";
            this.lblDestinations.Size = new System.Drawing.Size(86, 16);
            this.lblDestinations.TabIndex = 3;
            this.lblDestinations.Text = "Дестинации";
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.Location = new System.Drawing.Point(16, 316);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(319, 30);
            this.btnAddAirport.TabIndex = 4;
            this.btnAddAirport.Text = "Додади аеродром";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.Location = new System.Drawing.Point(16, 361);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(319, 30);
            this.btnDeleteAirport.TabIndex = 5;
            this.btnDeleteAirport.Text = "Избриши аеродром";
            this.btnDeleteAirport.UseVisualStyleBackColor = true;
            this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(16, 407);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(319, 30);
            this.btnAddDestination.TabIndex = 6;
            this.btnAddDestination.Text = "Додади дестинација";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // gbDestination
            // 
            this.gbDestination.Controls.Add(this.tbAverageDestLength);
            this.gbDestination.Controls.Add(this.tbMostExpensiveDest);
            this.gbDestination.Controls.Add(this.lblAverageLength);
            this.gbDestination.Controls.Add(this.lblMostExpensiveDest);
            this.gbDestination.Location = new System.Drawing.Point(342, 316);
            this.gbDestination.Name = "gbDestination";
            this.gbDestination.Size = new System.Drawing.Size(318, 121);
            this.gbDestination.TabIndex = 7;
            this.gbDestination.TabStop = false;
            this.gbDestination.Text = "Дестинации";
            // 
            // tbAverageDestLength
            // 
            this.tbAverageDestLength.Enabled = false;
            this.tbAverageDestLength.Location = new System.Drawing.Point(10, 88);
            this.tbAverageDestLength.Name = "tbAverageDestLength";
            this.tbAverageDestLength.Size = new System.Drawing.Size(302, 22);
            this.tbAverageDestLength.TabIndex = 3;
            // 
            // tbMostExpensiveDest
            // 
            this.tbMostExpensiveDest.Enabled = false;
            this.tbMostExpensiveDest.Location = new System.Drawing.Point(10, 42);
            this.tbMostExpensiveDest.Name = "tbMostExpensiveDest";
            this.tbMostExpensiveDest.Size = new System.Drawing.Size(302, 22);
            this.tbMostExpensiveDest.TabIndex = 2;
            // 
            // lblAverageLength
            // 
            this.lblAverageLength.AutoSize = true;
            this.lblAverageLength.Location = new System.Drawing.Point(7, 69);
            this.lblAverageLength.Name = "lblAverageLength";
            this.lblAverageLength.Size = new System.Drawing.Size(247, 16);
            this.lblAverageLength.TabIndex = 1;
            this.lblAverageLength.Text = "Просечна должина на дестинациите";
            // 
            // lblMostExpensiveDest
            // 
            this.lblMostExpensiveDest.AutoSize = true;
            this.lblMostExpensiveDest.Location = new System.Drawing.Point(7, 22);
            this.lblMostExpensiveDest.Name = "lblMostExpensiveDest";
            this.lblMostExpensiveDest.Size = new System.Drawing.Size(150, 16);
            this.lblMostExpensiveDest.TabIndex = 0;
            this.lblMostExpensiveDest.Text = "Најскапа дестинација";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 454);
            this.Controls.Add(this.gbDestination);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.btnDeleteAirport);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.lblDestinations);
            this.Controls.Add(this.lbDestinations);
            this.Controls.Add(this.lbAirports);
            this.Controls.Add(this.lblAirport);
            this.Name = "Form1";
            this.Text = "Аеродроми";
            this.gbDestination.ResumeLayout(false);
            this.gbDestination.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAirport;
        private System.Windows.Forms.ListBox lbAirports;
        private System.Windows.Forms.ListBox lbDestinations;
        private System.Windows.Forms.Label lblDestinations;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.GroupBox gbDestination;
        private System.Windows.Forms.Label lblMostExpensiveDest;
        private System.Windows.Forms.TextBox tbAverageDestLength;
        private System.Windows.Forms.TextBox tbMostExpensiveDest;
        private System.Windows.Forms.Label lblAverageLength;
    }
}

