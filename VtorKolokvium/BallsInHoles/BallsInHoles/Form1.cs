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

namespace BallsInHoles
{
    public partial class Form1 : Form
    {
        Scene scene;
        Color currentColor;
        Timer timer;
        public int LeftX;
        public int TopY;
        public int width;
        public int height;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            currentColor = Color.Red;
            this.DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            LeftX = 20;
            TopY = 60;
            width = this.Width - (3*LeftX);
            height = this.Height - (int)(2.5 * TopY);
            scene.GenerateHoles(LeftX, TopY,width,height);
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Pen p = new Pen(Color.Black, 3);
            e.Graphics.DrawRectangle(p, LeftX, TopY, width, height);
            p.Dispose();
            scene.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.MoveBalls(LeftX, TopY, width, height);
            scene.CheckColisions();
            Invalidate(true);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            width = this.Width - (3*LeftX);
            height = this.Height - (int)(2.5 * TopY);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            scene.GenerateHoles(LeftX,TopY,width,height);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene = new Scene();
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.AddBall(new Ball(e.Location, currentColor));
            Invalidate(true);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if(color.ShowDialog() == DialogResult.OK)
            {
                currentColor = color.Color;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
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
                scene = (Scene)formatter.Deserialize(filestream);
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
            using(FileStream filestream = new FileStream(path, FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(filestream, scene);
            }
        }

        private void tsslBallCounter_Paint(object sender, PaintEventArgs e)
        {
            tsslBallCounter.Text = string.Format("# Balls: {0}",scene.Balls.Count);
        }
    }
}
