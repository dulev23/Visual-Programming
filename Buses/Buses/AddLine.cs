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
    public partial class AddLine : Form
    {
        public DestinationLines line { get; set; }
        public AddLine()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            line = new DestinationLines(tbDestination.Text, (int)nudHour.Value, (int)nudMinute.Value, (int) nudPrice.Value);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tbDestination_Validating(object sender, CancelEventArgs e)
        {
            if(tbDestination.Text.Length == 0) 
            {
                errorProvider1.SetError(tbDestination, "Дестинацијата не смее да биде празна!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbDestination, null);
                e.Cancel = false;
            }
        }
    }
}
