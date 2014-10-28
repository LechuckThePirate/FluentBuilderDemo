using System.Collections.Generic;
using System.Drawing;

namespace FluentBuilderDemo
{
    public interface IPolyShape
    {
        int X { get; set; }
        int Y { get; set; }
        Color Color { get; set; }
        Color FillColor { get; set; }
        bool Closed { get; set; }
        List<Vector> Vectors { get; set; }
    }
}
