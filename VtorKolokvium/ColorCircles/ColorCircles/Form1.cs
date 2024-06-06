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

namespace ColorCircles
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Scene Scene;
        private Point CurrentPoint;
        private Point PreviousPoint;
        private int Radius;
        private Color CurrentColor;
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene();
            CurrentColor = Color.Green;
            this.DoubleBuffered = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (PreviousPoint.IsEmpty)
                {
                    PreviousPoint = e.Location;
                }
                else
                {
                    Scene.AddCircle(PreviousPoint, Radius, CurrentColor);
                    PreviousPoint = Point.Empty;
                    CurrentPoint = Point.Empty;
                }
                Invalidate(true);
            }
            
            if(e.Button == MouseButtons.Right)
            {
                Scene.Select(e.Location);
                Invalidate();   
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Scene.Draw(e.Graphics);
            if(!PreviousPoint.IsEmpty)
            {
                Pen linePen = new Pen(Color.Black, 3);
                linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                e.Graphics.DrawEllipse(linePen, PreviousPoint.X - Radius, PreviousPoint.Y - Radius, 2 * Radius, 2 * Radius);
                linePen.Dispose();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            CurrentPoint = e.Location;
            Radius = (int) Math.Sqrt(Circle.Distance(CurrentPoint, PreviousPoint));
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) 
            {
                PreviousPoint = Point.Empty;
                Invalidate();
            }
            if(e.KeyCode == Keys.Delete)
            {
                Scene.DeleteSelected();
                Invalidate(true);
            }
        }


        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                CurrentColor = cd.Color;
            }
        }

        private void tsslCirclesCounter_Paint(object sender, PaintEventArgs e)
        {
            tsslCirclesCounter.Text = string.Format("Circles: {0}",Scene.Circles.Count);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                string filename = openFile.FileName;
                deserializeScene(filename);
            }
        }

        private void deserializeScene(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                Scene = (Scene)formatter.Deserialize(fs);
            }
        }
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                string path = saveFile.FileName;
                serializeScene(path);
            }
        }

        private void serializeScene(string path)
        {
            using (FileStream fs = new FileStream(path,FileMode.OpenOrCreate))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs,Scene);
            }
        }
    }
}
