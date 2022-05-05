using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_05_2022
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics grp;
        Point[] p;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(bmp);

            // cu initializarile acestea putem sa desenam
            grp.DrawLine(Pens.Red, 10, 10, 300, 250);
            p = new Point[3];
            Random rnd = new Random();
            for (int i = 0; i < p.Length; i++)
            {
                p[i] = new Point((float)rnd.NextDouble()*pictureBox1.Width, (float)rnd.NextDouble()*pictureBox1.Height);
            }
            draw(p,Color.Black);
            pictureBox1.Image = bmp;
            Point[] S = new Point[p.Length];
            for(int i = 0; i < S.Length-1; i++)
            {
                float x = p[i].x + p[i + 1].x;
                float y = p[i].y + p[i + 1].y;
                S[i] = new Point();
                S[i].x = x / 2 ;
                S[i].y = y / 2 ;
            }
            S[S.Length-1] =new Point();
           S[S.Length-1].x = p[0].x + p[p.Length - 1].y;
           S[S.Length-1].y = p[0].y + p[p.Length - 1].y;
            draw(S,Color.Red);
        }

        void draw(Point[] p, Color t)
        {
            for (int i = 0; i < p.Length - 1; i++)
            {
                grp.DrawLine(new Pen(t), p[i].x, p[i].y, p[i + 1].x, p[i + 1].y);
            }
            grp.DrawLine(Pens.Red, p[p.Length - 1].x, p[p.Length - 1].y, p[0].x, p[0].y);
        }

    }
}
