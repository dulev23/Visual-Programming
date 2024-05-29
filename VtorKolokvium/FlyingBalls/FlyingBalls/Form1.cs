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

namespace FlyingBalls
{
    public partial class Form1 : Form
    {
        public Scene Scene { get; set; }
        public int TimerTicks { get; set; }
        public bool Started { get; set; } = true;
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene(this.Height, this.Width);
            timer1.Interval = 200;
            timer1.Start();
            TimerTicks = 0;
            this.DoubleBuffered = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++TimerTicks;
            if (TimerTicks % 10 == 0) //na izminata 1 sekunda
            {
                Scene.AddBall();
            }
            updateStatusLabels();
            Scene.Move();
            Invalidate(true);
        }

        private void updateStatusLabels()
        {
            tsslHits.Text = String.Format("Hits: {0}", Scene.Hits);
            tsslMisses.Text = String.Format("Misses: {0}", Scene.Misses);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Scene.Height = this.Height;
            Scene.Width = this.Width;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene.Hit(e.Location);
            Invalidate(true);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                String path = openFileDialog.FileName;
                deserializeScene(path);
            }
        }

        private void deserializeScene(string path)
        {
            using (FileStream filestream = new FileStream(path, FileMode.OpenOrCreate))
            {
                IFormatter formatter = new BinaryFormatter();
                Scene = (Scene) formatter.Deserialize(filestream); 
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String path = saveFileDialog.FileName;
                serializeScene(path);
            }
        }

        private void serializeScene(string path)
        {
            using (FileStream filestream = new FileStream(path, FileMode.OpenOrCreate))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(filestream, Scene);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene = new Scene(this.Height, this.Width);
            Invalidate();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Started = !Started;

            if (Started)
            {
                timer1.Start();
                pauseToolStripMenuItem.Text = "Pause";
            } else
            {
                pauseToolStripMenuItem.Text = "Resume";
                timer1.Stop();
            }
        }
    }
}
