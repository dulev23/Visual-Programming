namespace Airplane
{
    partial class AddDestination
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
            this.gbAddDestination = new System.Windows.Forms.GroupBox();
            this.lblDestinationName = new System.Windows.Forms.Label();
            this.tbDestinationName = new System.Windows.Forms.TextBox();
            this.lblDestinationLength = new System.Windows.Forms.Label();
            this.nudDestinationLength = new System.Windows.Forms.NumericUpDown();
            this.lblDestinationPrice = new System.Windows.Forms.Label();
            this.nudDestinationPrice = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbAddDestination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDestinationLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDestinationPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAddDestination
            // 
            this.gbAddDestination.Controls.Add(this.btnCancel);
            this.gbAddDestination.Controls.Add(this.btnAdd);
            this.gbAddDestination.Controls.Add(this.lblDestinationPrice);
            this.gbAddDestination.Controls.Add(this.nudDestinationPrice);
            this.gbAddDestination.Controls.Add(this.nudDestinationLength);
            this.gbAddDestination.Controls.Add(this.lblDestinationLength);
            this.gbAddDestination.Controls.Add(this.tbDestinationName);
            this.gbAddDestination.Controls.Add(this.lblDestinationName);
            this.gbAddDestination.Location = new System.Drawing.Point(13, 13);
            this.gbAddDestination.Name = "gbAddDestination";
            this.gbAddDestination.Size = new System.Drawing.Size(329, 242);
            this.gbAddDestination.TabIndex = 0;
            this.gbAddDestination.TabStop = false;
            this.gbAddDestination.Text = "Додади дестинација";
            // 
            // lblDestinationName
            // 
            this.lblDestinationName.AutoSize = true;
            this.lblDestinationName.Location = new System.Drawing.Point(6, 30);
            this.lblDestinationName.Name = "lblDestinationName";
            this.lblDestinationName.Size = new System.Drawing.Size(37, 16);
            this.lblDestinationName.TabIndex = 0;
            this.lblDestinationName.Text = "Име:";
            // 
            // tbDestinationName
            // 
            this.tbDestinationName.Location = new System.Drawing.Point(9, 50);
            this.tbDestinationName.Name = "tbDestinationName";
            this.tbDestinationName.Size = new System.Drawing.Size(286, 22);
            this.tbDestinationName.TabIndex = 1;
            this.tbDestinationName.Validating += new System.ComponentModel.CancelEventHandler(this.tbDestinationName_Validating);
            // 
            // lblDestinationLength
            // 
            this.lblDestinationLength.AutoSize = true;
            this.lblDestinationLength.Location = new System.Drawing.Point(6, 90);
            this.lblDestinationLength.Name = "lblDestinationLength";
            this.lblDestinationLength.Size = new System.Drawing.Size(65, 16);
            this.lblDestinationLength.TabIndex = 2;
            this.lblDestinationLength.Text = "Должина";
            // 
            // nudDestinationLength
            // 
            this.nudDestinationLength.Location = new System.Drawing.Point(9, 110);
            this.nudDestinationLength.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.nudDestinationLength.Name = "nudDestinationLength";
            this.nudDestinationLength.Size = new System.Drawing.Size(144, 22);
            this.nudDestinationLength.TabIndex = 3;
            // 
            // lblDestinationPrice
            // 
            this.lblDestinationPrice.AutoSize = true;
            this.lblDestinationPrice.Location = new System.Drawing.Point(6, 144);
            this.lblDestinationPrice.Name = "lblDestinationPrice";
            this.lblDestinationPrice.Size = new System.Drawing.Size(40, 16);
            this.lblDestinationPrice.TabIndex = 4;
            this.lblDestinationPrice.Text = "Цена";
            // 
            // nudDestinationPrice
            // 
            this.nudDestinationPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDestinationPrice.Location = new System.Drawing.Point(9, 163);
            this.nudDestinationPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDestinationPrice.Name = "nudDestinationPrice";
            this.nudDestinationPrice.Size = new System.Drawing.Size(144, 22);
            this.nudDestinationPrice.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 203);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Додади";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(173, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddDestination
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(354, 265);
            this.Controls.Add(this.gbAddDestination);
            this.Name = "AddDestination";
            this.Text = "Нова дестинација";
            this.gbAddDestination.ResumeLayout(false);
            this.gbAddDestination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDestinationLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDestinationPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddDestination;
        private System.Windows.Forms.Label lblDestinationLength;
        private System.Windows.Forms.TextBox tbDestinationName;
        private System.Windows.Forms.Label lblDestinationName;
        private System.Windows.Forms.Label lblDestinationPrice;
        private System.Windows.Forms.NumericUpDown nudDestinationPrice;
        private System.Windows.Forms.NumericUpDown nudDestinationLength;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}