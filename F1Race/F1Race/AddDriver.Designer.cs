namespace F1Race
{
    partial class AddDriver
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
            this.lblDriverName = new System.Windows.Forms.Label();
            this.tbDriverName = new System.Windows.Forms.TextBox();
            this.lblDriverAge = new System.Windows.Forms.Label();
            this.nudDriverAge = new System.Windows.Forms.NumericUpDown();
            this.cbFirstDriver = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudDriverAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.Location = new System.Drawing.Point(13, 13);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(34, 16);
            this.lblDriverName.TabIndex = 0;
            this.lblDriverName.Text = "Име";
            // 
            // tbDriverName
            // 
            this.tbDriverName.Location = new System.Drawing.Point(16, 32);
            this.tbDriverName.Name = "tbDriverName";
            this.tbDriverName.Size = new System.Drawing.Size(398, 22);
            this.tbDriverName.TabIndex = 1;
            this.tbDriverName.Validating += new System.ComponentModel.CancelEventHandler(this.tbDriverName_Validating);
            // 
            // lblDriverAge
            // 
            this.lblDriverAge.AutoSize = true;
            this.lblDriverAge.Location = new System.Drawing.Point(13, 72);
            this.lblDriverAge.Name = "lblDriverAge";
            this.lblDriverAge.Size = new System.Drawing.Size(62, 16);
            this.lblDriverAge.TabIndex = 2;
            this.lblDriverAge.Text = "Возраст";
            // 
            // nudDriverAge
            // 
            this.nudDriverAge.Location = new System.Drawing.Point(16, 91);
            this.nudDriverAge.Name = "nudDriverAge";
            this.nudDriverAge.Size = new System.Drawing.Size(153, 22);
            this.nudDriverAge.TabIndex = 3;
            // 
            // cbFirstDriver
            // 
            this.cbFirstDriver.AutoSize = true;
            this.cbFirstDriver.Location = new System.Drawing.Point(175, 92);
            this.cbFirstDriver.Name = "cbFirstDriver";
            this.cbFirstDriver.Size = new System.Drawing.Size(98, 20);
            this.cbFirstDriver.TabIndex = 4;
            this.cbFirstDriver.Text = "Прв возач";
            this.cbFirstDriver.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(16, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(224, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(190, 45);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Додади";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddDriver
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(432, 187);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbFirstDriver);
            this.Controls.Add(this.nudDriverAge);
            this.Controls.Add(this.lblDriverAge);
            this.Controls.Add(this.tbDriverName);
            this.Controls.Add(this.lblDriverName);
            this.Name = "AddDriver";
            this.Text = "AddDriver";
            ((System.ComponentModel.ISupportInitialize)(this.nudDriverAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.TextBox tbDriverName;
        private System.Windows.Forms.Label lblDriverAge;
        private System.Windows.Forms.NumericUpDown nudDriverAge;
        private System.Windows.Forms.CheckBox cbFirstDriver;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}