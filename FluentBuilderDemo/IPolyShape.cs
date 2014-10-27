using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
