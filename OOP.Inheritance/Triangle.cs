﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Triangle : Shape 
    {
        public override void Draw()
        {
            Console.WriteLine("bu metin virtual ile triangle için geldi");
        }


    }
}
