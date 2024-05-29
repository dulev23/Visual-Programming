using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlinePayments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            if(addStudent.ShowDialog() == DialogResult.OK)
            {
                lbStudents.Items.Add(addStudent.student);
            }
            
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            if(lbStudents.SelectedItems.Count > 0)
            {
                Student student = lbStudents.SelectedItem as Student;
                student.addPayment(new Payment(nudPayment.Value));
                UpdateDetails();
                UpdateStudentWithMaxPayments();
            }
        }

        private void lbStudents_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateDetails();
        }

        private void UpdateDetails()
        {
            if (lbStudents.SelectedItems.Count > 0)
            {
                Student student = lbStudents.SelectedItem as Student;
                lblStudentInfo.Text = student.Details();
            }
        }

        private void UpdateStudentWithMaxPayments()
        {
            Student max = lbStudents.Items[0] as Student;
            foreach (var item in lbStudents.Items)
            {
                Student student = item as Student; 
                if(student.TotalPaymentAmount() > max.TotalPaymentAmount())
                {
                    max = student;
                }
            }

            tbMaxPaymentStudent.Text = max.ToString();
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            if(lbStudents.SelectedItems.Count > 0 )
            {
                if(MessageBox.Show("Dali si siguren?", "Siguren li si?", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                {
                    Student selectedStudent = lbStudents.SelectedItem as Student;
                    selectedStudent.payments = new List<Payment>();
                    UpdateDetails();
                    UpdateStudentWithMaxPayments();
                }
                
            }
        }
    }
}
