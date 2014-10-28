using System;
using System.Drawing;
using System.Linq;

namespace FluentBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Square mySquare = new PolyShapeBuilder<Square>()
                .SetX(100)
                .SetY(100)
                .SetColor(Color.Blue)
                .SetFillColor("#FFFF00")
                .AddVector(new Vector(90, 100))
                .AddVector(new Vector(90, 100))
                .AddVector(new Vector(90, 100))
                .AddVector(new Vector(90, 100))
                .Build();

            Console.WriteLine(
                string.Format("We have here a nice Square with {0} vectors, "+
                                "positioned at {1},{2} in {3} color with {4} background!",
                            mySquare.Vectors.Count(), 
                            mySquare.X,
                            mySquare.Y,
                            mySquare.Color.Name, 
                            mySquare.FillColor.Name));

            Console.ReadLine();

        }
    }
}
