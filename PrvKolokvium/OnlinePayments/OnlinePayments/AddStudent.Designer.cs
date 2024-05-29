namespace OnlinePayments
{
    partial class AddStudent
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
            this.lblStudentIndex = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.tbStudentIndex = new System.Windows.Forms.TextBox();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentIndex
            // 
            this.lblStudentIndex.AutoSize = true;
            this.lblStudentIndex.Location = new System.Drawing.Point(41, 27);
            this.lblStudentIndex.Name = "lblStudentIndex";
            this.lblStudentIndex.Size = new System.Drawing.Size(55, 16);
            this.lblStudentIndex.TabIndex = 0;
            this.lblStudentIndex.Text = "Индекс";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(41, 83);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(105, 16);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Име и презиме";
            // 
            // tbStudentIndex
            // 
            this.tbStudentIndex.Location = new System.Drawing.Point(44, 46);
            this.tbStudentIndex.Name = "tbStudentIndex";
            this.tbStudentIndex.Size = new System.Drawing.Size(238, 22);
            this.tbStudentIndex.TabIndex = 2;
            this.tbStudentIndex.Validating += new System.ComponentModel.CancelEventHandler(this.tbStudentIndex_Validating);
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(44, 102);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(238, 22);
            this.tbStudentName.TabIndex = 3;
            this.tbStudentName.Validating += new System.ComponentModel.CancelEventHandler(this.tbStudentName_Validating);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(44, 154);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(238, 27);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Додади студент";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(44, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(238, 27);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddStudent
            // 
            this.AcceptButton = this.btnAddStudent;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(323, 252);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.tbStudentName);
            this.Controls.Add(this.tbStudentIndex);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentIndex);
            this.Name = "AddStudent";
            this.Text = "Додавање на нов студент";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentIndex;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox tbStudentIndex;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}