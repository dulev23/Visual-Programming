namespace OnlinePayments
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
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.nudPayment = new System.Windows.Forms.NumericUpDown();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.tbMaxPaymentStudent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.ItemHeight = 16;
            this.lbStudents.Location = new System.Drawing.Point(71, 61);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(216, 356);
            this.lbStudents.TabIndex = 0;
            this.lbStudents.SelectedValueChanged += new System.EventHandler(this.lbStudents_SelectedValueChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(71, 435);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(216, 34);
            this.btnAddStudent.TabIndex = 1;
            this.btnAddStudent.Text = "Додади студент";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.Location = new System.Drawing.Point(71, 488);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(216, 34);
            this.btnDeletePayment.TabIndex = 2;
            this.btnDeletePayment.Text = "Избриши уплати";
            this.btnDeletePayment.UseVisualStyleBackColor = true;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // nudPayment
            // 
            this.nudPayment.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPayment.Location = new System.Drawing.Point(324, 61);
            this.nudPayment.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.nudPayment.Name = "nudPayment";
            this.nudPayment.Size = new System.Drawing.Size(203, 22);
            this.nudPayment.TabIndex = 3;
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Location = new System.Drawing.Point(321, 155);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(44, 16);
            this.lblStudentInfo.TabIndex = 4;
            this.lblStudentInfo.Text = "label1";
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(324, 101);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(203, 34);
            this.btnAddPayment.TabIndex = 5;
            this.btnAddPayment.Text = "Додади уплата";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // tbMaxPaymentStudent
            // 
            this.tbMaxPaymentStudent.Enabled = false;
            this.tbMaxPaymentStudent.Location = new System.Drawing.Point(333, 395);
            this.tbMaxPaymentStudent.Name = "tbMaxPaymentStudent";
            this.tbMaxPaymentStudent.Size = new System.Drawing.Size(194, 22);
            this.tbMaxPaymentStudent.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 545);
            this.Controls.Add(this.tbMaxPaymentStudent);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.lblStudentInfo);
            this.Controls.Add(this.nudPayment);
            this.Controls.Add(this.btnDeletePayment);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lbStudents);
            this.Name = "Form1";
            this.Text = "OnlinePayments";
            ((System.ComponentModel.ISupportInitialize)(this.nudPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeletePayment;
        private System.Windows.Forms.NumericUpDown nudPayment;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.TextBox tbMaxPaymentStudent;
    }
}

