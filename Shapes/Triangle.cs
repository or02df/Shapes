using System.Drawing;

namespace Shapes
{
    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public double GetArea()
        {
            return 0.5 * Base * Height;
        }

        public double GetPerimeter()
        {
            // Approximate perimeter (equilateral triangle for simplicity)
            return 3 * Base;
        }

        public void Draw(Graphics g, Point center)
        {
            PointF[] points = {
            new PointF(center.X, center.Y - (float)(Height / 2)), // Top point
            new PointF(center.X - (float)(Base / 2), center.Y + (float)(Height / 2)), // Bottom-left
            new PointF(center.X + (float)(Base / 2), center.Y + (float)(Height / 2)) // Bottom-right
        };
            g.DrawPolygon(Pens.Black, points);
        }
    }
}
