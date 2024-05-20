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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Airport arp1 = new Airport("Александар Велики","Скопје","SKP");
            arp1.AddDestination(new Destination("Виена",1240,260));
            lbAirports.Items.Add(arp1);
            Airport arp2 = new Airport("Ел Прат", "Барселона", "BAR");
            lbAirports.Items.Add(arp2);
            Airport arp3 = new Airport("Виена ИА", "Виена", "VIE");
            lbAirports.Items.Add(arp3);
            Airport arp4 = new Airport("Ататурк ИА", "Истанбул", "IST");
            lbAirports.Items.Add(arp4);
            loadChanges();
        }

        void loadChanges()
        {
            lbDestinations.Items.Clear();
            tbAverageDestLength.Clear();
            tbMostExpensiveDest.Clear();
            Airport airport = lbAirports.SelectedItem as Airport;
            if (airport != null && airport.Destinations.Count > 0) 
            {
                Destination maxPrice = airport.Destinations[0];
                float totalDistance = 0;
                foreach (Destination destination in airport.Destinations) 
                {
                    lbDestinations.Items.Add(destination);
                    if(destination.Price > maxPrice.Price)
                    {
                        maxPrice = destination;
                    }
                    totalDistance += destination.Distance;
                }
                tbAverageDestLength.Text = string.Format("{0:#.0}", totalDistance / lbDestinations.Items.Count);
                tbMostExpensiveDest.Text = maxPrice.ToString();
            }
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            NewAirport newAirport = new NewAirport();
            if (newAirport.ShowDialog() == DialogResult.OK)
            {
                lbAirports.Items.Add(newAirport.Airport);
            }
        }

        private void btnDeleteAirport_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Дали сте сигурни дека сакате да го избришете аеродромот?","Избриши аеродром",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbAirports.Items.RemoveAt(lbAirports.SelectedIndex);
                loadChanges();
            }
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            AddDestination addDestination = new AddDestination();
            if(addDestination.ShowDialog() == DialogResult.OK)
            {
                Airport airports = lbAirports.SelectedItem as Airport;
                airports.AddDestination(addDestination.Destination);
                loadChanges();
            }
        }

        private void lbAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteAirport.Enabled = lbAirports.SelectedIndex != -1;
            btnAddDestination.Enabled = lbAirports.SelectedIndex != -1;
            loadChanges();
        }

        private void tbAverageDestLength_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
