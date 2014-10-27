using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderDemo
{
    public class Vector
    {
        decimal Orientation { get; set; }
        int Magnitude { get; set; }

        public Vector(decimal orientation, int magnitude)
        {
            this.Orientation = orientation;
            this.Magnitude = magnitude;
        }
    }
}
