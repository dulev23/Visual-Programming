using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashAccount
{
    public partial class AddNew : Form
    {
        public Product Product { get; set; }
        public AddNew()
        {
            InitializeComponent();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if(tbName.Text.Length == 0)
            {
                errorProvider1.SetError(tbName, "Продуктот мора да има име!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product = new Product((int)nudCode.Value,tbName.Text,(float)nudPrice.Value);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
