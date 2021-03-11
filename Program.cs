using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape324
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Shape>();

            list.Add(new Triangle(10, 20));
            list.Add(new Rectangle(10, 20));
            list.Add(new Circle(10));
            



            Console.WriteLine($"Area of Triangle: {list[0].CalculateSurface()}");
            Console.WriteLine($"Area of Rectangle: {list[1].CalculateSurface()}");
            Console.WriteLine($"Area of Circle: {list[2].CalculateSurface()}");
            Console.ReadKey();
        }
    }
}
