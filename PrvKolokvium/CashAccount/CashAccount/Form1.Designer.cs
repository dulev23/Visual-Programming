namespace CashAccount
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
            this.gbProducts = new System.Windows.Forms.GroupBox();
            this.gbPaycheck = new System.Windows.Forms.GroupBox();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.lbPaycheck = new System.Windows.Forms.ListBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToPaycheck = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDeletePaycheck = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbToPay = new System.Windows.Forms.TextBox();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblToPay = new System.Windows.Forms.Label();
            this.nudFee = new System.Windows.Forms.NumericUpDown();
            this.gbProducts.SuspendLayout();
            this.gbPaycheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFee)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProducts
            // 
            this.gbProducts.Controls.Add(this.btnAddNew);
            this.gbProducts.Controls.Add(this.btnAddToPaycheck);
            this.gbProducts.Controls.Add(this.nudQuantity);
            this.gbProducts.Controls.Add(this.lblQuantity);
            this.gbProducts.Controls.Add(this.lbProducts);
            this.gbProducts.Location = new System.Drawing.Point(13, 13);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Size = new System.Drawing.Size(268, 492);
            this.gbProducts.TabIndex = 0;
            this.gbProducts.TabStop = false;
            this.gbProducts.Text = "Продукти";
            // 
            // gbPaycheck
            // 
            this.gbPaycheck.Controls.Add(this.nudFee);
            this.gbPaycheck.Controls.Add(this.lblToPay);
            this.gbPaycheck.Controls.Add(this.lblFee);
            this.gbPaycheck.Controls.Add(this.tbToPay);
            this.gbPaycheck.Controls.Add(this.tbTotal);
            this.gbPaycheck.Controls.Add(this.lblTotal);
            this.gbPaycheck.Controls.Add(this.btnDeletePaycheck);
            this.gbPaycheck.Controls.Add(this.lbPaycheck);
            this.gbPaycheck.Location = new System.Drawing.Point(298, 13);
            this.gbPaycheck.Name = "gbPaycheck";
            this.gbPaycheck.Size = new System.Drawing.Size(337, 492);
            this.gbPaycheck.TabIndex = 1;
            this.gbPaycheck.TabStop = false;
            this.gbPaycheck.Text = "Сметка";
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 16;
            this.lbProducts.Location = new System.Drawing.Point(7, 22);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(255, 292);
            this.lbProducts.TabIndex = 0;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // lbPaycheck
            // 
            this.lbPaycheck.FormattingEnabled = true;
            this.lbPaycheck.ItemHeight = 16;
            this.lbPaycheck.Location = new System.Drawing.Point(6, 22);
            this.lbPaycheck.Name = "lbPaycheck";
            this.lbPaycheck.Size = new System.Drawing.Size(325, 260);
            this.lbPaycheck.TabIndex = 1;
            this.lbPaycheck.SelectedIndexChanged += new System.EventHandler(this.lbPaycheck_SelectedIndexChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(7, 335);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(74, 16);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Количина:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(84, 331);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(176, 24);
            this.nudQuantity.TabIndex = 2;
            this.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddToPaycheck
            // 
            this.btnAddToPaycheck.Location = new System.Drawing.Point(10, 388);
            this.btnAddToPaycheck.Name = "btnAddToPaycheck";
            this.btnAddToPaycheck.Size = new System.Drawing.Size(250, 36);
            this.btnAddToPaycheck.TabIndex = 3;
            this.btnAddToPaycheck.Text = "Додади во сметка";
            this.btnAddToPaycheck.UseVisualStyleBackColor = true;
            this.btnAddToPaycheck.Click += new System.EventHandler(this.btnAddToPaycheck_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(10, 441);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(250, 36);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = " Додади нов";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDeletePaycheck
            // 
            this.btnDeletePaycheck.Location = new System.Drawing.Point(7, 288);
            this.btnDeletePaycheck.Name = "btnDeletePaycheck";
            this.btnDeletePaycheck.Size = new System.Drawing.Size(324, 37);
            this.btnDeletePaycheck.TabIndex = 2;
            this.btnDeletePaycheck.Text = "Избриши сметка";
            this.btnDeletePaycheck.UseVisualStyleBackColor = true;
            this.btnDeletePaycheck.Click += new System.EventHandler(this.btnDeletePaycheck_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(17, 350);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 16);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Вкупно:";
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(126, 345);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(203, 24);
            this.tbTotal.TabIndex = 4;
            // 
            // tbToPay
            // 
            this.tbToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbToPay.Location = new System.Drawing.Point(126, 453);
            this.tbToPay.Name = "tbToPay";
            this.tbToPay.Size = new System.Drawing.Size(203, 24);
            this.tbToPay.TabIndex = 6;
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(17, 405);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(73, 16);
            this.lblFee.TabIndex = 7;
            this.lblFee.Text = "Данок (%):";
            // 
            // lblToPay
            // 
            this.lblToPay.AutoSize = true;
            this.lblToPay.Location = new System.Drawing.Point(17, 458);
            this.lblToPay.Name = "lblToPay";
            this.lblToPay.Size = new System.Drawing.Size(85, 16);
            this.lblToPay.TabIndex = 8;
            this.lblToPay.Text = "За плаќање";
            // 
            // nudFee
            // 
            this.nudFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFee.Location = new System.Drawing.Point(126, 401);
            this.nudFee.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudFee.Name = "nudFee";
            this.nudFee.Size = new System.Drawing.Size(203, 24);
            this.nudFee.TabIndex = 9;
            this.nudFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudFee.ValueChanged += new System.EventHandler(this.nudFee_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 517);
            this.Controls.Add(this.gbPaycheck);
            this.Controls.Add(this.gbProducts);
            this.Name = "Form1";
            this.Text = "Каса";
            this.gbProducts.ResumeLayout(false);
            this.gbProducts.PerformLayout();
            this.gbPaycheck.ResumeLayout(false);
            this.gbPaycheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.Button btnAddToPaycheck;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.GroupBox gbPaycheck;
        private System.Windows.Forms.ListBox lbPaycheck;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox tbToPay;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnDeletePaycheck;
        private System.Windows.Forms.Label lblToPay;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.NumericUpDown nudFee;
    }
}

