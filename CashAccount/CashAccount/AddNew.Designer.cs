namespace CashAccount
{
    partial class AddNew
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
            this.gbProduct = new System.Windows.Forms.GroupBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.nudCode = new System.Windows.Forms.NumericUpDown();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProduct
            // 
            this.gbProduct.Controls.Add(this.nudPrice);
            this.gbProduct.Controls.Add(this.lblPrice);
            this.gbProduct.Controls.Add(this.tbName);
            this.gbProduct.Controls.Add(this.lblName);
            this.gbProduct.Controls.Add(this.nudCode);
            this.gbProduct.Controls.Add(this.lblCode);
            this.gbProduct.Location = new System.Drawing.Point(13, 13);
            this.gbProduct.Name = "gbProduct";
            this.gbProduct.Size = new System.Drawing.Size(483, 210);
            this.gbProduct.TabIndex = 0;
            this.gbProduct.TabStop = false;
            this.gbProduct.Text = "Податоци за продуктот";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(7, 33);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(34, 16);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Код:";
            // 
            // nudCode
            // 
            this.nudCode.Location = new System.Drawing.Point(10, 52);
            this.nudCode.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCode.Name = "nudCode";
            this.nudCode.Size = new System.Drawing.Size(164, 22);
            this.nudCode.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 16);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Име:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(10, 113);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(442, 22);
            this.tbName.TabIndex = 3;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(7, 155);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(43, 16);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Цена:";
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(10, 174);
            this.nudPrice.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(164, 22);
            this.nudPrice.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(281, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Внеси";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(402, 240);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddNew
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(508, 280);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbProduct);
            this.Name = "AddNew";
            this.Text = "Нов продукт";
            this.gbProduct.ResumeLayout(false);
            this.gbProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProduct;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown nudCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}