using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buses
{
    public partial class NewBus : Form
    {
        public Bus Bus { get; set; }
        public NewBus()
        {
            InitializeComponent();
        }

        private void tbBusName_Validating(object sender, CancelEventArgs e)
        {
            if(tbBusName.Text.Trim().Length == 0 )
            {
                errorProvider1.SetError(tbBusName,"Автобусот мора да има име!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbBusName, null);
                e.Cancel = false;
            }
        }

        private void tbBusRegistration_Validating(object sender, CancelEventArgs e)
        {
            if(tbBusRegistration.Text.Trim().Length != 4 ) 
            {
                errorProvider1.SetError(tbBusRegistration,"Регистрацијата мора да содржи точно 4 цифри!");
                e.Cancel = true;
            } 
            else
            {
                string reg = tbBusRegistration.Text.Trim();
                foreach(char c in reg)
                {
                    if (!Char.IsDigit(c))
                    {
                        errorProvider1.SetError(tbBusRegistration, "Регистрацијата мора да содржи точно 4 цифри!");
                        e.Cancel = true;
                        return;
                    }
                }
                errorProvider1.SetError(tbBusRegistration, null);
                e.Cancel = false; 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Bus = new Bus(tbBusRegistration.Text.Trim(), tbBusName.Text.Trim(), cbIsLocal.Checked);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
