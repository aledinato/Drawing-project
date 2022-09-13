using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace ProgettoCad
{
    [Serializable]
    [XmlInclude(typeof(Linea))]
    public class Rettangolo:Figura
    {
        private Point p1;
        public int p1X { get; set; }
        public int p1Y { get; set; }

        private Point p2;
        public int p2X { get; set; }
        public int p2Y { get; set; }

        public Rettangolo()
        {
            p1 = new Point();
            p2 = new Point();
        }

        public override List<Point> DammiPunti()
        {
            List<Point> l = new List<Point>();
            l.Add(p1);
            l.Add(p2);
            return l;
        }
        public Point AltoSx()
        {
            Point p;
            if (p1.X > p2.X && p1.Y > p2.Y)
            { p = p2; }
            else if (p1.X < p2.X && p1.Y < p2.Y)
            { p = p1; }
            else if (p1.X > p2.X && p1.Y < p2.Y)
            {
                p = p1;
                p.X = p2.X;
            }
            else 
            {
                p = p1;
                p.Y = p2.Y;
            }
            return p;
        }

        public void AssegnaPunti(Point p1,Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
            p1X = p1.X;
            p1Y = p1.Y;
            p2X = p2.X;
            p2Y = p2.Y;
        }

        public override void AssegnaCoordinate()
        {
            p2.X = p2X;
            p2.Y = p2Y;
            p1.X = p1X;
            p1.Y = p1Y;
        }

        public override void Disegna(Graphics g)
        {
            Rectangle r = new Rectangle();
            r.Location = AltoSx();
            r.Width = Math.Abs(p2.X-p1.X);
            r.Height = Math.Abs(p2.Y-p1.Y);
            Pen p = new Pen(Color.FromArgb(Alpha,R,G,B), Width);
            g.DrawRectangle(p, r);
        }

        public override void Sposta(int deltaX, int deltaY)
        {
            p1.Offset(deltaX, deltaY);
            p2.Offset(deltaX, deltaY);
            AssegnaPunti(p1, p2);
        }

        public override void AssegnaPunti(List<Point> l)
        {
            p1 = l[0];
            p2 = l[1];
        }
    }
}
