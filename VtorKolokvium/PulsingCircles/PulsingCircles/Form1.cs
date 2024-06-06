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

namespace PulsingCircles
{
    [Serializable]
    public partial class Form1 : Form
    {
        Scene scene;
        Color currentColor;
        bool IsStarted;
        Timer timer;
        string filename;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            currentColor = Color.Blue;
            IsStarted = false;
            timer = new Timer();
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = 100;
            filename = "Untitled";
            this.DoubleBuffered = true;
        }

        private void tsslTotalCircles_Paint(object sender, PaintEventArgs e)
        {
            tsslTotalCircles.Text = string.Format("Total: {0}", scene.circles.Count);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                scene.AddCircle(e.Location,currentColor);
            }
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            scene.Draw(e.Graphics);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            if(cdlg.ShowDialog() == DialogResult.OK)
            {
                currentColor = cdlg.Color;
            }
        }

        private void tsbStartStop_Click(object sender, EventArgs e)
        {
            IsStarted = !IsStarted;
            if (IsStarted)
            {
                tsbStartStop.Text = "Стоп";
                timer1.Start();
            }
            else
            {
                tsbStartStop.Text = "Старт";
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.Pulse();
            Invalidate(true);
        }

        private void OpenFile()
        {
            OpenFileDialog ofg = new OpenFileDialog();
            if(ofg.ShowDialog() == DialogResult.OK)
            {
                filename = ofg.FileName;
                using (FileStream fs = new FileStream(filename,FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    scene = (Scene)formatter.Deserialize(fs);
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

        private void SaveFile()
        {
            if (filename == null)
            {
                SaveFileDialog sfg = new SaveFileDialog();
                sfg.FileName = filename;
                if (sfg.ShowDialog() == DialogResult.OK)
                {
                    filename = sfg.FileName;
                }
            }
            if (filename != null)
            {
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, scene);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void NewFile()
        {
            scene = new Scene();
            Invalidate(true);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            NewFile();
        }
    }
}
