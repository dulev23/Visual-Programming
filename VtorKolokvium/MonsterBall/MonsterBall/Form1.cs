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

namespace MonsterBall
{
    [Serializable]
    public partial class Form1 : Form
    {
        Scene scene;
        Color color;
        int width, height;
        int leftX, topY;
        string FileName;
        Timer timer;

        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            color = Color.Blue;
            leftX = 20;
            topY = 60;
            width = this.Width - (3 * leftX);
            height = this.Height - (int)(2.5 * topY);
            this.DoubleBuffered = true;
            FileName = "Untitled";
            scene.GenerateHoles(leftX,topY,width,height);
            timer = new Timer();
            timer.Interval = 50;
            timer.Start();
            timer.Tick += new EventHandler(timer1_Tick);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Pen p = new Pen(Color.Black, 3);
            e.Graphics.DrawRectangle(p,leftX,topY,width,height);
            p.Dispose();
            scene.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.AddBall(new Ball(e.Location));
            Invalidate(true);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            width = this.Width - (3 * leftX);
            height = this.Height - (int)(2.5 * topY);
            Invalidate(true);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            scene = new Scene();
            Invalidate(true);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene = new Scene();
            Invalidate(true);
        }

        private void OpenFile()
        {
            OpenFileDialog ofg = new OpenFileDialog();
            if (ofg.ShowDialog() == DialogResult.OK)
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
            if(FileName == null)
            {
                SaveFileDialog sfg = new SaveFileDialog();
                sfg.FileName = FileName;
                if(sfg.ShowDialog() == DialogResult.OK)
                {
                    FileName = sfg.FileName;
                }
            }
            if(FileName!=null)
            {
                using (FileStream fs = new FileStream(FileName,FileMode.OpenOrCreate))
                {
                    IFormatter formatter= new BinaryFormatter();
                    formatter.Serialize(fs, scene);
                }
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void tsbGenerateHoles_Click(object sender, EventArgs e)
        {
            scene.GenerateHoles(leftX, topY, width, height);
            Invalidate(true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scene.MoveBalls(leftX, topY, width, height);
            scene.CheckColisions();
            Invalidate(true);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cdlg = new ColorDialog();
            if(cdlg.ShowDialog() == DialogResult.OK)
            {
                color = cdlg.Color;
            }
        }

        private void tsslBallCounter_Paint(object sender, PaintEventArgs e)
        {
            tsslBallCounter.Text = string.Format("#Balls: {0}", scene.balls.Count);
        }
    }
}
