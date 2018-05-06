using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap btm;
        Pen pen;

        public Form1()
        {
            InitializeComponent();

            pen = new Pen(Color.AliceBlue);
            btm = new Bitmap(500, 500);
            pictureBox1.Image = btm;
            g = Graphics.FromImage(btm);
            g.Clear(Color.White);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 500);
            int y = 0;
            g.DrawEllipse(pen, x, y, 20, 20);
        }
    }
}
