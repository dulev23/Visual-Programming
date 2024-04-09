using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertor
{
    public partial class AddConvertor : Form
    {
        public Convertor Convertor { get; set; }
        public AddConvertor()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Convertor = new Convertor(tbFrom.Text, tbTo.Text,(int)nudMultiplier.Value);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbFrom_Validating(object sender, CancelEventArgs e)
        {
            if(tbFrom.Text.Length == 0) 
            {
                errorProvider1.SetError(tbFrom,"Полето не смее да биде празно!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbFrom, null);
                e.Cancel = false;
            }
        }

        private void tbTo_Validating(object sender, CancelEventArgs e)
        {
            if(tbTo.Text.Length == 0)
            {
                errorProvider1.SetError(tbTo, "Полето не смее да биде празно!");
            }
            else
            {
                errorProvider1.SetError(tbTo, null);
                e.Cancel = false;
            }
        }

        private void nudMultiplier_Validating(object sender, CancelEventArgs e)
        {
            if(nudMultiplier.Value == 0)
            {
                errorProvider1.SetError(nudMultiplier, "Вредноста треба да биде поголема од 0");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(nudMultiplier, null);
                e.Cancel = false;
            }
        }
    }
}
