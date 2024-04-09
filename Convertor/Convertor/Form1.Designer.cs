namespace Convertor
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
            this.lblConvertor = new System.Windows.Forms.Label();
            this.lbConvertors = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.nudFrom = new System.Windows.Forms.NumericUpDown();
            this.lblTo = new System.Windows.Forms.Label();
            this.nudTo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConvertor
            // 
            this.lblConvertor.AutoSize = true;
            this.lblConvertor.Location = new System.Drawing.Point(13, 13);
            this.lblConvertor.Name = "lblConvertor";
            this.lblConvertor.Size = new System.Drawing.Size(86, 16);
            this.lblConvertor.TabIndex = 0;
            this.lblConvertor.Text = "Конвертори";
            // 
            // lbConvertors
            // 
            this.lbConvertors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConvertors.FormattingEnabled = true;
            this.lbConvertors.ItemHeight = 25;
            this.lbConvertors.Location = new System.Drawing.Point(16, 33);
            this.lbConvertors.Name = "lbConvertors";
            this.lbConvertors.Size = new System.Drawing.Size(261, 404);
            this.lbConvertors.TabIndex = 1;
            this.lbConvertors.SelectedIndexChanged += new System.EventHandler(this.lbConvertors_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 460);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(261, 43);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Додади";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 509);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(261, 43);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Избриши";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(421, 33);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(108, 48);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "EUR";
            this.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudFrom
            // 
            this.nudFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFrom.Location = new System.Drawing.Point(296, 84);
            this.nudFrom.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudFrom.Name = "nudFrom";
            this.nudFrom.Size = new System.Drawing.Size(233, 53);
            this.nudFrom.TabIndex = 5;
            this.nudFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudFrom.ValueChanged += new System.EventHandler(this.nudFrom_ValueChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(416, 151);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(113, 48);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "MKD";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nudTo
            // 
            this.nudTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTo.Location = new System.Drawing.Point(296, 202);
            this.nudTo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudTo.Name = "nudTo";
            this.nudTo.Size = new System.Drawing.Size(233, 53);
            this.nudTo.TabIndex = 7;
            this.nudTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTo.ValueChanged += new System.EventHandler(this.nudTo_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 571);
            this.Controls.Add(this.nudTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.nudFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbConvertors);
            this.Controls.Add(this.lblConvertor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConvertor;
        private System.Windows.Forms.ListBox lbConvertors;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.NumericUpDown nudFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.NumericUpDown nudTo;
    }
}

