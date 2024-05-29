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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Racer Racer1 = new Racer("Vettel",32,true);
            Racer Racer2 = new Racer("Raikkonen", 34, false);
            Racer Racer3 = new Racer("Hamilton", 26, false);
            lbRaceDrivers.Items.Add(Racer1);
            lbRaceDrivers.Items.Add(Racer2);
            lbRaceDrivers.Items.Add(Racer3);
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            AddDriver addDriver = new AddDriver();
            if(addDriver.ShowDialog() == DialogResult.OK)
            {
                
                lbRaceDrivers.Items.Add(addDriver.Racer);
            }
        }

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Дали сте сигурни дека сакате да го избришете возачот?","Избриши возач",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbRaceDrivers.Items.RemoveAt(lbRaceDrivers.SelectedIndex);
            }
        }

        private void btnAddLap_Click(object sender, EventArgs e)
        {
            Laps AddLap = new Laps((int) nudMinutes.Value, (int) nudSeconds.Value);
            Racer racer = lbRaceDrivers.SelectedItem as Racer;
            racer.Laps.Add(AddLap);
            nudMinutes.Value = 0;
            nudSeconds.Value = 0;
            showLaps();
        }

        void showLaps()
        {
            Racer racer = lbRaceDrivers.SelectedItem as Racer;
            lbRaceLaps.Items.Clear();
            if(racer != null && racer.Laps.Count > 0) 
            {
                int time = (int)nudTime.Value;
                Laps best = racer.Laps[0];
                foreach(Laps lap in  racer.Laps)
                {
                    if(time > 0)
                    {
                        if (lap.Time > time)
                        {
                            lbRaceLaps.Items.Add(lap);
                        }
                    }
                    else
                    {
                        lbRaceLaps.Items.Add(lap);
                    }
                    if (lap.Time < best.Time)
                    {
                        best = lap;
                    }
                }
                tbBestLap.Text = best.ToString();
            }
            else
            {
                tbBestLap.Clear();
            }
        }

        private void nudSeconds_ValueChanged(object sender, EventArgs e)
        {
            int value = (int) nudSeconds.Value;
            if (value < 0)
            {
                int min = (int)nudMinutes.Value;
                if(min > 0)
                {
                    nudMinutes.Value = min - 1;
                    nudSeconds.Value = 59;
                }
                else
                {
                    nudSeconds.Value = 0;
                }
            }
            else
            {
                nudSeconds.Value = value % 60;
                nudMinutes.Value += value / 60;
            }
        }

        private void lbRaceDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddLap.Enabled = lbRaceDrivers.SelectedIndex != -1;
            btnDeleteDriver.Enabled = lbRaceDrivers.SelectedIndex != -1;
            showLaps(); 
        }
    }
}
