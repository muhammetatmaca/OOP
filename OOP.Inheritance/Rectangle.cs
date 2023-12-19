using System;

namespace OOP.Inheritance
{
    public class Rectangle : Shape
    {

        public Rectangle()
        {
            
        }

        public Rectangle(int x,int y)
        {
            X = x; 
            Y = y;
        }
        public override void Draw()
        {
            Console.WriteLine("bu virtual edilen metin rectangle ile geldi");
        }

        public void Calculate()
        {
            Console.WriteLine("calculated rectangle");
        }
    }
}
