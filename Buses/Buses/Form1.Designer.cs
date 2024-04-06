namespace Buses
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
            this.lblBus = new System.Windows.Forms.Label();
            this.lblLines = new System.Windows.Forms.Label();
            this.lbBuses = new System.Windows.Forms.ListBox();
            this.lbBusLines = new System.Windows.Forms.ListBox();
            this.btnAddBus = new System.Windows.Forms.Button();
            this.btnDeleteBus = new System.Windows.Forms.Button();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.gbLines = new System.Windows.Forms.GroupBox();
            this.tbAverageLinePrice = new System.Windows.Forms.TextBox();
            this.lblAverageLinePrice = new System.Windows.Forms.Label();
            this.tbMostExpensiveLine = new System.Windows.Forms.TextBox();
            this.lblMostExpensiveLine = new System.Windows.Forms.Label();
            this.gbLines.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBus
            // 
            this.lblBus.AutoSize = true;
            this.lblBus.Location = new System.Drawing.Point(25, 26);
            this.lblBus.Name = "lblBus";
            this.lblBus.Size = new System.Drawing.Size(70, 16);
            this.lblBus.TabIndex = 0;
            this.lblBus.Text = "Автобуси";
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.Location = new System.Drawing.Point(321, 26);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(48, 16);
            this.lblLines.TabIndex = 1;
            this.lblLines.Text = "Линии";
            // 
            // lbBuses
            // 
            this.lbBuses.FormattingEnabled = true;
            this.lbBuses.ItemHeight = 16;
            this.lbBuses.Location = new System.Drawing.Point(28, 45);
            this.lbBuses.Name = "lbBuses";
            this.lbBuses.Size = new System.Drawing.Size(290, 276);
            this.lbBuses.TabIndex = 2;
            // 
            // lbBusLines
            // 
            this.lbBusLines.FormattingEnabled = true;
            this.lbBusLines.ItemHeight = 16;
            this.lbBusLines.Location = new System.Drawing.Point(324, 45);
            this.lbBusLines.Name = "lbBusLines";
            this.lbBusLines.Size = new System.Drawing.Size(290, 276);
            this.lbBusLines.TabIndex = 3;
            // 
            // btnAddBus
            // 
            this.btnAddBus.Location = new System.Drawing.Point(28, 337);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(291, 31);
            this.btnAddBus.TabIndex = 4;
            this.btnAddBus.Text = "Додади автобус";
            this.btnAddBus.UseVisualStyleBackColor = true;
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // btnDeleteBus
            // 
            this.btnDeleteBus.Location = new System.Drawing.Point(28, 383);
            this.btnDeleteBus.Name = "btnDeleteBus";
            this.btnDeleteBus.Size = new System.Drawing.Size(291, 31);
            this.btnDeleteBus.TabIndex = 5;
            this.btnDeleteBus.Text = "Избриши автобус";
            this.btnDeleteBus.UseVisualStyleBackColor = true;
            this.btnDeleteBus.Click += new System.EventHandler(this.btnDeleteBus_Click);
            // 
            // btnAddLine
            // 
            this.btnAddLine.Location = new System.Drawing.Point(28, 429);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(291, 31);
            this.btnAddLine.TabIndex = 6;
            this.btnAddLine.Text = "Додади линија";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // gbLines
            // 
            this.gbLines.Controls.Add(this.tbAverageLinePrice);
            this.gbLines.Controls.Add(this.lblAverageLinePrice);
            this.gbLines.Controls.Add(this.tbMostExpensiveLine);
            this.gbLines.Controls.Add(this.lblMostExpensiveLine);
            this.gbLines.Location = new System.Drawing.Point(325, 327);
            this.gbLines.Name = "gbLines";
            this.gbLines.Size = new System.Drawing.Size(291, 133);
            this.gbLines.TabIndex = 7;
            this.gbLines.TabStop = false;
            this.gbLines.Text = "Линии";
            // 
            // tbAverageLinePrice
            // 
            this.tbAverageLinePrice.Enabled = false;
            this.tbAverageLinePrice.Location = new System.Drawing.Point(9, 90);
            this.tbAverageLinePrice.Name = "tbAverageLinePrice";
            this.tbAverageLinePrice.Size = new System.Drawing.Size(276, 22);
            this.tbAverageLinePrice.TabIndex = 3;
            this.tbAverageLinePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAverageLinePrice
            // 
            this.lblAverageLinePrice.AutoSize = true;
            this.lblAverageLinePrice.Location = new System.Drawing.Point(6, 71);
            this.lblAverageLinePrice.Name = "lblAverageLinePrice";
            this.lblAverageLinePrice.Size = new System.Drawing.Size(184, 16);
            this.lblAverageLinePrice.TabIndex = 2;
            this.lblAverageLinePrice.Text = "Просечна цена на линиите";
            // 
            // tbMostExpensiveLine
            // 
            this.tbMostExpensiveLine.Enabled = false;
            this.tbMostExpensiveLine.Location = new System.Drawing.Point(9, 45);
            this.tbMostExpensiveLine.Name = "tbMostExpensiveLine";
            this.tbMostExpensiveLine.Size = new System.Drawing.Size(276, 22);
            this.tbMostExpensiveLine.TabIndex = 1;
            // 
            // lblMostExpensiveLine
            // 
            this.lblMostExpensiveLine.AutoSize = true;
            this.lblMostExpensiveLine.Location = new System.Drawing.Point(6, 25);
            this.lblMostExpensiveLine.Name = "lblMostExpensiveLine";
            this.lblMostExpensiveLine.Size = new System.Drawing.Size(112, 16);
            this.lblMostExpensiveLine.TabIndex = 0;
            this.lblMostExpensiveLine.Text = "Најскапа линија";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 478);
            this.Controls.Add(this.gbLines);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.btnDeleteBus);
            this.Controls.Add(this.btnAddBus);
            this.Controls.Add(this.lbBusLines);
            this.Controls.Add(this.lbBuses);
            this.Controls.Add(this.lblLines);
            this.Controls.Add(this.lblBus);
            this.Name = "Form1";
            this.Text = "Автобуси";
            this.gbLines.ResumeLayout(false);
            this.gbLines.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBus;
        private System.Windows.Forms.Label lblLines;
        private System.Windows.Forms.ListBox lbBuses;
        private System.Windows.Forms.ListBox lbBusLines;
        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.Button btnDeleteBus;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.GroupBox gbLines;
        private System.Windows.Forms.TextBox tbAverageLinePrice;
        private System.Windows.Forms.Label lblAverageLinePrice;
        private System.Windows.Forms.TextBox tbMostExpensiveLine;
        private System.Windows.Forms.Label lblMostExpensiveLine;
    }
}

