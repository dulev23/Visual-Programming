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
    public partial class AddDestination : Form
    {
        public Destination Destination { get; set; }
        public AddDestination()
        {
            InitializeComponent();
        }

        private void tbDestinationName_Validating(object sender, CancelEventArgs e)
        {
            if(tbDestinationName.Text.Length ==  0)
            {
                errorProvider1.SetError(tbDestinationName,"Името не смее да биде празно!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbDestinationName, null);
                e.Cancel = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Destination = new Destination(tbDestinationName.Text,(int) nudDestinationLength.Value,(int) nudDestinationPrice.Value);
            DialogResult = DialogResult.OK;
        }
    }
}
