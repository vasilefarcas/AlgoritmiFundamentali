using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _09_05_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        Pen blackPen = new Pen(Color.Black);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            StreamReader read = new StreamReader(@"..\..\..\TextFile1.txt");
            List<Point> points = new List<Point>();
            string linie;
            int count=0;
            do
            {
                linie = read.ReadLine();
                points.Add(CitirePunct(read.ReadLine()));
                g.DrawEllipse(blackPen, ReturnareX(points[count]), ReturnareY(points[count]),1,1);
                count++;
            }
            while (linie != null);


        }
        Point CitirePunct(string a)
        {
            int x, y;
            string[] buff = a.Split(' ');
            x = int.Parse(buff[0]);
            y = int.Parse(buff[1]);
            return new Point(x, y);
        }
        int ReturnareX(Point x) => x.X;
        int ReturnareY(Point x) => x.Y;

    }
}
