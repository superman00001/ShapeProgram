using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeProgram.Data;

namespace ShapeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(4, 5);
            Rectangle rectangle = new Rectangle(2, 2);
            Circle circle = new Circle(3, 3);

            List<double> surfaces = new List<double>();

            surfaces.Add(triangle.CalculateSurface());
            surfaces.Add(rectangle.CalculateSurface());
            surfaces.Add(circle.CalculateSurface());

            foreach (var surface in surfaces)
            {
                Console.WriteLine(surface);
            }
        }
    }
}