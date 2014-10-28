using System.Collections.Generic;
using System.Drawing;

namespace FluentBuilderDemo
{
    public class Square : IPolyShape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }
        public Color FillColor { get; set; }
        public bool Closed { get; set; }
        public List<Vector> Vectors { get; set; }

        public Square()
        {
            Closed = true;
            Vectors = new List<Vector>();
        }
    }
}
