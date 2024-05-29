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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bus bus = new Bus("5463","ЈСП 5", true);
            bus.AddDestination(new DestinationLines("Аеродром", 12, 5, 35));
            lbBuses.Items.Add(bus);
            loadChanges();
        }        

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            NewBus newBus = new NewBus();
            if(newBus.ShowDialog() == DialogResult.OK)
            {
                lbBuses.Items.Add(newBus.Bus);
            }
        }

        private void btnDeleteBus_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Дали сте сигурни дека сакате да го избришете автобусот?","Избриши автобус",MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                lbBuses.Items.RemoveAt(lbBuses.SelectedIndex);
                loadChanges();
            }
        }

        private void btnAddLine_Click(object sender, EventArgs e)
        {
            AddLine addLine = new AddLine();
            if(addLine.ShowDialog() == DialogResult.OK)
            {
                Bus busLine = lbBuses.SelectedItem as Bus;
                busLine.AddDestination(addLine.line);
                loadChanges();
            }
        }

        void loadChanges()
        {
            lbBusLines.Items.Clear();
            tbAverageLinePrice.Clear();
            tbMostExpensiveLine.Clear();
            Bus bus = lbBuses.SelectedItem as Bus;
            if(bus != null && bus.Lines.Count > 0)
            {
                DestinationLines maxLine = bus.Lines[0];
                float totalPrice = 0;
                foreach (DestinationLines line in bus.Lines)
                {
                    lbBusLines.Items.Add(line);
                    if(maxLine.price < line.price)
                    {
                        maxLine = line;
                    }
                    totalPrice += line.price;
                }
                tbAverageLinePrice.Text = string.Format("{0:#.0}", totalPrice / lbBusLines.Items.Count);
                tbMostExpensiveLine.Text = maxLine.ToString();
            }
        }
    }
}
