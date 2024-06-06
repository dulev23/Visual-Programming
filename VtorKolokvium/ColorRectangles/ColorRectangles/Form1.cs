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

namespace ColorRectangles
{
    [Serializable]
    public partial class Form1 : Form
    {
        private Scene scene;
        private Color currentColor;
        private Point currentPoint;
        private Point previousPoint;
        private int x, y;
        private int width, height;
        public Form1()
        {
            InitializeComponent();
            newDocument();
            currentColor = Color.Blue;
            this.DoubleBuffered = true;
        }

        private void newDocument()
        {
            scene = new Scene();
            currentPoint = Point.Empty;
            previousPoint = Point.Empty;
        }

        private void tsslRectanglesCount_Paint(object sender, PaintEventArgs e)
        {
            tsslRectanglesCount.Text = string.Format("Rectangles: {0}",scene.Rectangles.Count);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (previousPoint.IsEmpty)
                {
                    previousPoint = e.Location;
                }
                else
                {
                    scene.AddRectangle(new Point(x, y), width, height, currentColor);
                    previousPoint = Point.Empty;
                    currentPoint = Point.Empty;
                }
                Invalidate(true);
            }
            if(e.Button == MouseButtons.Right)
            {
                scene.Select(e.Location);
                Invalidate();   
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            scene.Draw(e.Graphics);
            if (!previousPoint.IsEmpty)
            {
                Pen pen = new Pen(Color.Black, 2);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                e.Graphics.DrawRectangle(pen,x,y,width,height);
                pen.Dispose();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currentPoint = e.Location;
            x = previousPoint.X;
            y = previousPoint.Y;
            if (x > currentPoint.X) { x = currentPoint.X; }
            if (y > currentPoint.Y) { y = currentPoint.Y; }
            width = Math.Abs(previousPoint.X - currentPoint.X);
            height = Math.Abs(previousPoint.Y - currentPoint.Y);
            Invalidate(true);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                currentColor = dlg.Color;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            if(ofg.ShowDialog() == DialogResult.OK)
            {
                string filename = ofg.FileName;
                deserializeScene(filename);
            }
        }

        public void deserializeScene(string path)
        {
            using (FileStream fs = new FileStream(path,FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                scene = (Scene) formatter.Deserialize(fs);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                scene.DeleteSelected();
                Invalidate(true);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newDocument();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfg = new SaveFileDialog();
            if(sfg.ShowDialog() == DialogResult.OK)
            {
                string filename = sfg.FileName;
                serializeScene(filename);
            }
        }

        public void serializeScene(string path)
        {
            using (FileStream fs = new FileStream(path,FileMode.OpenOrCreate))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs,scene);
            }
        }
    }
}
