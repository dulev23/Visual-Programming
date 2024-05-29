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

namespace Ellipse
{
    public partial class Form1 : Form
    {
        private Scene Scene;
        private Point firstPoint;
        private Point lastPoint;
        private string FileName;
        private int x, y;
        private int width, height;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            newFile();
            timer1.Start();
        }

        private void newFile()
        {
            Scene = new Scene();
            firstPoint = Point.Empty;
            lastPoint = Point.Empty;
            FileName = "Untitled";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            x = firstPoint.X;
            y = firstPoint.Y;
            if(x > lastPoint.X) { x = lastPoint.X; }
            if(y > lastPoint.Y) { y = lastPoint.Y; }
            width = Math.Abs(firstPoint.X - lastPoint.X);
            height = Math.Abs(firstPoint.Y - lastPoint.Y);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            Scene.Draw(e.Graphics);
            if (!firstPoint.IsEmpty)
            {
                Pen linePen = new Pen(Color.Black, 2);
                linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawEllipse(linePen, x, y, width, height);
                linePen.Dispose();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Scene.ChangeColor();
            Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
            Invalidate(true);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                deserializeScene(FileName);
            }
        }

        private void deserializeScene(string path)
        {
            using(FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                Scene = (Scene)formatter.Deserialize(fileStream);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName=saveFileDialog.FileName;
                serializeScene(FileName);
            }
        }

        private void serializeScene(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream,Scene);
            }

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (firstPoint.IsEmpty)
            {
                firstPoint = e.Location;
            }
            else
            {
                Scene.AddCircle(new Point(x,y),width,height);
                firstPoint = Point.Empty;
                lastPoint = Point.Empty;
            }
            Invalidate(true);
        }
    }
}
