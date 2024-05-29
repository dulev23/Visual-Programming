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
    public partial class Form1 : Form
    {
        Convertor current;
        public Form1()
        {
            InitializeComponent();
            Convertor conv1 = new Convertor("EUR","MKD",61.5m);
            Convertor conv2 = new Convertor("KG", "T", 1000m);
            lbConvertors.Items.Add(conv1);
            lbConvertors.Items.Add(conv2);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbConvertors.SelectedIndex != -1)
            {
                if (MessageBox.Show("Дали сте сигурни дека сакате да го избришете конверторот?", "Избриши конвертор", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbConvertors.Items.RemoveAt(lbConvertors.SelectedIndex);
                    nudFrom.Value = 0;
                    nudTo.Value = 0;
                    lblFrom.Text = "FROM";
                    lblTo.Text = "TO";
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddConvertor addConvertor = new AddConvertor();
            if(addConvertor.ShowDialog() == DialogResult.OK)
            {
                lbConvertors.Items.Add(addConvertor.Convertor);
            }
        }

        private void lbConvertors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbConvertors.SelectedIndex != -1)
            {
                current = lbConvertors.SelectedItem as Convertor;
                lblFrom.Text = current.From;
                lblTo.Text = current.To;
                nudFrom.Value = 1;
                nudTo.Value = nudFrom.Value * current.Multiplier;
            }
            nudFrom.Enabled = lbConvertors.SelectedIndex != -1;
            nudTo.Enabled = lbConvertors.SelectedIndex != -1;
        }

        private void nudFrom_ValueChanged(object sender, EventArgs e)
        {
            nudTo.Value = nudFrom.Value * current.Multiplier;
        }

        private void nudTo_ValueChanged(object sender, EventArgs e)
        {
            nudFrom.Value = nudTo.Value / current.Multiplier;
        }
    }
}
