namespace Airplane
{
    partial class NewAirport
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
            this.components = new System.ComponentModel.Container();
            this.gbAddAirport = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbAirportShortcut = new System.Windows.Forms.TextBox();
            this.lblAirportShortcut = new System.Windows.Forms.Label();
            this.tbAirportName = new System.Windows.Forms.TextBox();
            this.tbAirportCity = new System.Windows.Forms.TextBox();
            this.lblAirportName = new System.Windows.Forms.Label();
            this.lblAirportCity = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAddAirport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddAirport
            // 
            this.gbAddAirport.Controls.Add(this.btnCancel);
            this.gbAddAirport.Controls.Add(this.btnSave);
            this.gbAddAirport.Controls.Add(this.tbAirportShortcut);
            this.gbAddAirport.Controls.Add(this.lblAirportShortcut);
            this.gbAddAirport.Controls.Add(this.tbAirportName);
            this.gbAddAirport.Controls.Add(this.tbAirportCity);
            this.gbAddAirport.Controls.Add(this.lblAirportName);
            this.gbAddAirport.Controls.Add(this.lblAirportCity);
            this.gbAddAirport.Location = new System.Drawing.Point(13, 13);
            this.gbAddAirport.Name = "gbAddAirport";
            this.gbAddAirport.Size = new System.Drawing.Size(348, 240);
            this.gbAddAirport.TabIndex = 0;
            this.gbAddAirport.TabStop = false;
            this.gbAddAirport.Text = "Додади Аеродром";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(174, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 27);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 27);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Зачувај";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbAirportShortcut
            // 
            this.tbAirportShortcut.Location = new System.Drawing.Point(10, 142);
            this.tbAirportShortcut.Name = "tbAirportShortcut";
            this.tbAirportShortcut.Size = new System.Drawing.Size(126, 22);
            this.tbAirportShortcut.TabIndex = 5;
            this.tbAirportShortcut.Validating += new System.ComponentModel.CancelEventHandler(this.tbAirportShortcut_Validating);
            // 
            // lblAirportShortcut
            // 
            this.lblAirportShortcut.AutoSize = true;
            this.lblAirportShortcut.Location = new System.Drawing.Point(7, 123);
            this.lblAirportShortcut.Name = "lblAirportShortcut";
            this.lblAirportShortcut.Size = new System.Drawing.Size(72, 16);
            this.lblAirportShortcut.TabIndex = 4;
            this.lblAirportShortcut.Text = "Кратенка:";
            // 
            // tbAirportName
            // 
            this.tbAirportName.Location = new System.Drawing.Point(10, 86);
            this.tbAirportName.Name = "tbAirportName";
            this.tbAirportName.Size = new System.Drawing.Size(290, 22);
            this.tbAirportName.TabIndex = 3;
            this.tbAirportName.Validating += new System.ComponentModel.CancelEventHandler(this.tbAirportName_Validating);
            // 
            // tbAirportCity
            // 
            this.tbAirportCity.Location = new System.Drawing.Point(10, 42);
            this.tbAirportCity.Name = "tbAirportCity";
            this.tbAirportCity.Size = new System.Drawing.Size(290, 22);
            this.tbAirportCity.TabIndex = 2;
            this.tbAirportCity.Validating += new System.ComponentModel.CancelEventHandler(this.tbAirportCity_Validating);
            // 
            // lblAirportName
            // 
            this.lblAirportName.AutoSize = true;
            this.lblAirportName.Location = new System.Drawing.Point(7, 67);
            this.lblAirportName.Name = "lblAirportName";
            this.lblAirportName.Size = new System.Drawing.Size(37, 16);
            this.lblAirportName.TabIndex = 1;
            this.lblAirportName.Text = "Име:";
            // 
            // lblAirportCity
            // 
            this.lblAirportCity.AutoSize = true;
            this.lblAirportCity.Location = new System.Drawing.Point(7, 22);
            this.lblAirportCity.Name = "lblAirportCity";
            this.lblAirportCity.Size = new System.Drawing.Size(38, 16);
            this.lblAirportCity.TabIndex = 0;
            this.lblAirportCity.Text = "Град";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NewAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 265);
            this.Controls.Add(this.gbAddAirport);
            this.Name = "NewAirport";
            this.Text = "Нов аеродром";
            this.gbAddAirport.ResumeLayout(false);
            this.gbAddAirport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddAirport;
        private System.Windows.Forms.Label lblAirportCity;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbAirportShortcut;
        private System.Windows.Forms.Label lblAirportShortcut;
        private System.Windows.Forms.TextBox tbAirportName;
        private System.Windows.Forms.TextBox tbAirportCity;
        private System.Windows.Forms.Label lblAirportName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}