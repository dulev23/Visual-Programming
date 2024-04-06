namespace VisualProgramming
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbAllCourses = new ListBox();
            clbEnrolledCourses = new CheckedListBox();
            tbCourseName = new TextBox();
            btnAdd = new Button();
            btnMoveToEnrolled = new Button();
            btnMoveBackToAllCourses = new Button();
            SuspendLayout();
            // 
            // lbAllCourses
            // 
            lbAllCourses.FormattingEnabled = true;
            lbAllCourses.Location = new Point(160, 62);
            lbAllCourses.Name = "lbAllCourses";
            lbAllCourses.SelectionMode = SelectionMode.MultiSimple;
            lbAllCourses.Size = new Size(181, 284);
            lbAllCourses.TabIndex = 0;
            // 
            // clbEnrolledCourses
            // 
            clbEnrolledCourses.FormattingEnabled = true;
            clbEnrolledCourses.Location = new Point(525, 62);
            clbEnrolledCourses.Name = "clbEnrolledCourses";
            clbEnrolledCourses.Size = new Size(180, 290);
            clbEnrolledCourses.TabIndex = 1;
            // 
            // tbCourseName
            // 
            tbCourseName.Location = new Point(160, 361);
            tbCourseName.Name = "tbCourseName";
            tbCourseName.Size = new Size(181, 27);
            tbCourseName.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(160, 404);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Course";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnMoveToEnrolled
            // 
            btnMoveToEnrolled.Location = new Point(397, 121);
            btnMoveToEnrolled.Name = "btnMoveToEnrolled";
            btnMoveToEnrolled.Size = new Size(71, 29);
            btnMoveToEnrolled.TabIndex = 4;
            btnMoveToEnrolled.Text = ">>";
            btnMoveToEnrolled.UseVisualStyleBackColor = true;
            btnMoveToEnrolled.Click += btnMoveToEnrolled_Click;
            // 
            // btnMoveBackToAllCourses
            // 
            btnMoveBackToAllCourses.Location = new Point(397, 179);
            btnMoveBackToAllCourses.Name = "btnMoveBackToAllCourses";
            btnMoveBackToAllCourses.Size = new Size(71, 29);
            btnMoveBackToAllCourses.TabIndex = 5;
            btnMoveBackToAllCourses.Text = "<<";
            btnMoveBackToAllCourses.UseVisualStyleBackColor = true;
            btnMoveBackToAllCourses.Click += btnMoveBackToAllCourses_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 493);
            Controls.Add(btnMoveBackToAllCourses);
            Controls.Add(btnMoveToEnrolled);
            Controls.Add(btnAdd);
            Controls.Add(tbCourseName);
            Controls.Add(clbEnrolledCourses);
            Controls.Add(lbAllCourses);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbAllCourses;
        private CheckedListBox clbEnrolledCourses;
        private TextBox tbCourseName;
        private Button btnAdd;
        private Button btnMoveToEnrolled;
        private Button btnMoveBackToAllCourses;
    }
}
