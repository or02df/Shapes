using System;
using System.Drawing;

namespace Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public void Draw(Graphics g, Point center)
        {
            int diameter = (int)(2 * Radius);
            g.DrawEllipse(Pens.Black, center.X - (int)Radius, center.Y - (int)Radius, diameter, diameter);
        }
    }
}
