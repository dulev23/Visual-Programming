using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airplane
{
    public partial class NewAirport : Form
    {
        public Airport Airport { get; set; }
        public NewAirport()
        {
            InitializeComponent();
        }

        private void tbAirportCity_Validating(object sender, CancelEventArgs e)
        {
            if(tbAirportCity.Text.Length == 0 )
            {
                errorProvider1.SetError(tbAirportCity,"Името на градот не смее да биде празно!");
                e.Cancel = true;
            } else
            {
                errorProvider1.SetError(tbAirportCity, null);
                e.Cancel= false;
            }
        }

        private void tbAirportName_Validating(object sender, CancelEventArgs e)
        {
            if (tbAirportName.Text.Length == 0)
            {
                errorProvider1.SetError(tbAirportName, "Името на аеродромот не смее да биде празно");
                e.Cancel = true;
            } else
            {
                errorProvider1.SetError (tbAirportName, null);
                e.Cancel= false;
            }
        }

        private void tbAirportShortcut_Validating(object sender, CancelEventArgs e)
        {
            if(tbAirportShortcut.Text.Length != 3)
            {
                errorProvider1.SetError(tbAirportShortcut,"Кратенката треба да има точно 3 големи букви");
                e.Cancel = true;
            } else
            {
                string sh = tbAirportShortcut.Text;
                foreach(char c in sh)
                {
                    if(Char.IsLower(c))
                    {
                        errorProvider1.SetError(tbAirportShortcut,"Кратенката треба да има точно 3 големи букви");
                        e.Cancel = true;
                        return;
                    }
                }
                errorProvider1.SetError(tbAirportShortcut,null);
                e.Cancel = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Airport = new Airport(tbAirportName.Text,tbAirportCity.Text,tbAirportShortcut.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
