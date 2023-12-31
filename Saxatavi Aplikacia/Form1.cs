using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saxatavi_Aplikacia
{
    public partial class Form1 : Form
    {
        int x=-1,y=-1;
        bool mausisModzraoba=false;
        Graphics g;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            panel1.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            g = panel1.CreateGraphics();
            pen = new Pen(Color.DarkSeaGreen, 5);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
            mausisModzraoba = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            x = -1;
            y = -1;
            mausisModzraoba= false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           pen.Width=(float) numericUpDown1.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox1.BackColor;
            pen.Width = (float)numericUpDown1.Value;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox2.BackColor;
            pen.Width = (float)numericUpDown1.Value;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox3.BackColor;
            pen.Width = (float)numericUpDown1.Value;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox4.BackColor;
            pen.Width = (float)numericUpDown1.Value;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pen.Color = pictureBox5.BackColor;
            pen.Width = (float)numericUpDown1.Value;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
            pen.Width = 10;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mausisModzraoba = true && x != -1 && y != -1){
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }
    }
}
