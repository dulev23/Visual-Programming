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
using System.Windows.Forms.VisualStyles;

namespace SlidingBalls
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Scene scene;
        public string FileName;
        Timer timer1;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene(this.Width,this.Height);
            FileName = "Untitled";
            this.DoubleBuffered = true;
            timer1 = new Timer();
            timer1.Interval = 50;
            timer1.Tick += new EventHandler(timer_Tick);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                scene.AddRed(e.Location);
                Invalidate(true);
                return;
            }
            if (scene.Click(e.Location))
            {
                timer.Start();
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                scene.AddBall(e.Location);
            }
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            scene.Draw(e.Graphics);
        }

        private void tsslBallsCounter_Paint(object sender, PaintEventArgs e)
        {
            tsslBallsCounter.Text = string.Format("Active: {0}",scene.Balls.Count);
        }

        private void openFile()  
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                using (FileStream fs = new FileStream(FileName, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    scene = (Scene)formatter.Deserialize(fs);
                }
            }
            Invalidate(true);
        }

        private void saveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = FileName;
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream fs = new FileStream(FileName,FileMode.OpenOrCreate))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs,scene);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (scene.MoveBalls())
            {
                timer1.Stop();
            }
            Invalidate(true);
        }
    }
}