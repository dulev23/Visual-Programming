using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Race
{
    public partial class AddDriver : Form
    {
        public Racer Racer;
        public AddDriver()
        {
            InitializeComponent();
        }

        private void tbDriverName_Validating(object sender, CancelEventArgs e)
        {
            if(tbDriverName.Text.Length == 0)
            {
                errorProvider1.SetError(tbDriverName,"Името на возачот не смее да биде празно");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbDriverName, null);
                e.Cancel = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Racer = new Racer(tbDriverName.Text,(int)nudDriverAge.Value,cbFirstDriver.Checked);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
