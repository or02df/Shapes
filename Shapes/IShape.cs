using System.Drawing;

namespace Shapes
{
    public interface IShape
    {

        double GetArea();

        double GetPerimeter();

        void Draw(Graphics g, Point center);
    }
}
