using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickingPies
{
    [Serializable]
    public partial class Form1 : Form
    {
        Scene scene;
        Color color;
        string FileName;
        Timer timer;
        bool StartStop;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            color = Color.Blue;
            this.DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            StartStop = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            scene.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.AddPie(e.Location, color);
            Invalidate();
            Invalidate(true);
        }

        private void tsslPieCounter_Paint(object sender, PaintEventArgs e)
        {
            tsslPieCounter.Text = string.Format("Counter: {0}",scene.pies.Count);
        }


        private void OpenFile()
        {
            OpenFileDialog ofg = new OpenFileDialog();
            if(ofg.ShowDialog() == DialogResult.OK)
            {
                FileName = ofg.FileName;
                using (FileStream fs = new FileStream(FileName, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    scene = (Scene)formatter.Deserialize(fs);
                }
            }
        }

        private void SaveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog sfg = new SaveFileDialog();
                sfg.FileName = FileName;
                if(sfg.ShowDialog() == DialogResult.OK)
                {
                    FileName = sfg.FileName;
                }
            }
            if(FileName != null)
            {
                using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, scene);
                }
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            scene = new Scene();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene = new Scene();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.Tick();
            Invalidate(true);
        }

        private void tsbStartStop_Click(object sender, EventArgs e)
        {
            //
            if (StartStop)
            {
                timer.Stop();
                tsbStartStop.Text = "Старт";
            }
            else
            {
                timer.Start();
                tsbStartStop.Text = "Стоп";
            }
            StartStop = !StartStop;
        }
    }
}
