namespace Buses
{
    partial class AddLine
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
            this.gbAddLine = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAddLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddLine
            // 
            this.gbAddLine.Controls.Add(this.btnCancel);
            this.gbAddLine.Controls.Add(this.btnAdd);
            this.gbAddLine.Controls.Add(this.nudPrice);
            this.gbAddLine.Controls.Add(this.lblPrice);
            this.gbAddLine.Controls.Add(this.nudMinute);
            this.gbAddLine.Controls.Add(this.nudHour);
            this.gbAddLine.Controls.Add(this.lblMinute);
            this.gbAddLine.Controls.Add(this.lblHour);
            this.gbAddLine.Controls.Add(this.tbDestination);
            this.gbAddLine.Controls.Add(this.lblDestination);
            this.gbAddLine.Location = new System.Drawing.Point(13, 13);
            this.gbAddLine.Name = "gbAddLine";
            this.gbAddLine.Size = new System.Drawing.Size(343, 218);
            this.gbAddLine.TabIndex = 0;
            this.gbAddLine.TabStop = false;
            this.gbAddLine.Text = "Додади линија";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 27);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 179);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 27);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Додади";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudPrice
            // 
            this.nudPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPrice.Location = new System.Drawing.Point(23, 140);
            this.nudPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(134, 22);
            this.nudPrice.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(23, 120);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 16);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Цена:";
            // 
            // nudMinute
            // 
            this.nudMinute.Location = new System.Drawing.Point(136, 91);
            this.nudMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(86, 22);
            this.nudMinute.TabIndex = 5;
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(20, 91);
            this.nudHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(97, 22);
            this.nudHour.TabIndex = 4;
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(133, 71);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(57, 16);
            this.lblMinute.TabIndex = 3;
            this.lblMinute.Text = "Минута";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(20, 71);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(31, 16);
            this.lblHour.TabIndex = 2;
            this.lblHour.Text = "Час";
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(20, 42);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(296, 22);
            this.tbDestination.TabIndex = 1;
            this.tbDestination.Validating += new System.ComponentModel.CancelEventHandler(this.tbDestination_Validating);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(17, 22);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(92, 16);
            this.lblDestination.TabIndex = 0;
            this.lblDestination.Text = "Дестинација:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddLine
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 243);
            this.Controls.Add(this.gbAddLine);
            this.Name = "AddLine";
            this.Text = "Нова линија";
            this.gbAddLine.ResumeLayout(false);
            this.gbAddLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddLine;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}