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
    public partial class AddStudent : Form
    {
        public Student student {  get; set; }

        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            student = new Student(tbStudentIndex.Text, tbStudentName.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }

        private void tbStudentIndex_Validating(object sender, CancelEventArgs e)
        {
            if (tbStudentIndex.Text.Length == 6)
            {
                errorProvider1.SetError(tbStudentIndex, null);
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(tbStudentIndex, "Индексот мора да биде стринг со 6 знаци!");
                e.Cancel = true;
            }
        }

        private void tbStudentName_Validating(object sender, CancelEventArgs e)
        {
            if (tbStudentName.Text.Length > 0)
            {
                errorProvider1.SetError(tbStudentName, null);
                e.Cancel = false;
            }
            else
            {
                errorProvider1.SetError(tbStudentName, "Името не смее да биде празно!");
                e.Cancel = true;
            }
        }
    }
}