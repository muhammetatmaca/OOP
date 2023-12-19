using System;

namespace OOP.Inheritance
{
    public partial class Shape
    {
        public Shape(int x, int y)
        {
            X= x;
            Y= y;
        }
        public Shape()
        {
            
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("base class draw");
        }

    }
}
