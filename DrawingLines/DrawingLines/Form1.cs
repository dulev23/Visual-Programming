using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingLines
{
    public partial class Form1 : Form
    {
        Scene scene;
        public Form1()
        {
            InitializeComponent();
            scene = new Scene(this.Width,this.Height);
            this.DoubleBuffered = true;
            countLinesStatusLabel.Text = "Lines: 0";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.AddPoint(e.Location);
            scene.UndoStack.Clear();
            UpdateStatus();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                scene.Color = dlg.Color;
            }
        }

        private void thinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thinToolStripMenuItem.Checked = true;
            normalToolStripMenuItem.Checked = false;
            thickToolStripMenuItem.Checked = false;
            scene.Thickness = 1;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            normalToolStripMenuItem.Checked = true;
            thinToolStripMenuItem.Checked = false;
            thickToolStripMenuItem.Checked = false;
            scene.Thickness = 2;
        }

        private void thickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thickToolStripMenuItem.Checked = true;
            thinToolStripMenuItem.Checked = false;
            normalToolStripMenuItem.Checked = false;
            scene.Thickness = 3;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            scene.Cursor = e.Location;
            Invalidate();
        }

        private void UpdateStatus()
        {
            countLinesStatusLabel.Text = $"Lines: {scene.Lines.Count}";
        }

        private void positionerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene.Positioner = !scene.Positioner;
            positionerToolStripMenuItem.Checked = !positionerToolStripMenuItem.Checked;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene.Undo();
            UpdateStatus();
            Invalidate();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scene.Redo();
            UpdateStatus();
            Invalidate();
        }
    }
}
