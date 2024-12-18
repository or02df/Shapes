using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        public void Draw(Graphics g, Point center)
        {
            int x = center.X - (int)(Width / 2);
            int y = center.Y - (int)(Height / 2);
            g.DrawRectangle(Pens.Black, x, y, (int)Width, (int)Height);
        }
    }

}
