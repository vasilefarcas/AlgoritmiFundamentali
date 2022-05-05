using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace _05_05_2022
{
    internal class Point
    {
        public float x, y;
        Random rnd=new Random();
        public Point(float x, float y)
        {
            this.x = (float)x;
            this.y = (float)y;
        }
        public Point()
        {

        }
        public float getX()
        {
            return this.x;
        }
        public float getY()
        {
            return this.y;
        }
        public Point getMid(Point x)
        {
            return new Point((this.x + x.x) / 2, (this.y + x.y) / 2);
        }
        public void draw(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Black), x - 3, y - 3, 7, 7);
            
        }
    }
}
