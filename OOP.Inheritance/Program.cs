using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var s1 = new Rectangle(12, 22);

            Console.WriteLine("{0},{1}",s1.X,s1.Y);

            Console.ReadKey();

        }

        private static void kullanım2()
        {
            var shapes = new List<Shape>()
            {
                new Circle(),
                new Rectangle(),
                new Triangle()

            };

            foreach (var shape in shapes)
            {
                shape.Draw();

            }

            new Square().Calculate();
        }

        private static void VirtualMethod()
        {
            var s1 = new Rectangle();
            var s2 = new Circle();

            s1.x = 1;
            s2.x = 2;

            Console.WriteLine("{0},{1}", s1.x, s2.x);

            new Triangle().Draw();
        }
    }
}
