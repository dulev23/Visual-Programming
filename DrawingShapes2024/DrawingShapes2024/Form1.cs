using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingShapes2024
{
    public partial class Form1 : Form
    {
        public string ShapeType { get; set; } = "CIRCLE";
        public Scene Scene { get; set; }
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene();
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circleToolStripMenuItem.Checked = false;
            squareToolStripMenuItem.Checked = true;
            ShapeType = "SQUARE";
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            squareToolStripMenuItem.Checked = false;
            circleToolStripMenuItem.Checked = true;
            ShapeType = "CIRCLE";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (ShapeType.Equals("CIRCLE"))
                {
                    Scene.AddShape(new Circle(Color.Red, e.Location, 20));
                }
                else
                {
                    Scene.AddShape(new Square(Color.Red, e.Location, 40));
                }

            } else
            {
                Scene.Hit(e.Location);
            }

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics);
        }
    }
}
