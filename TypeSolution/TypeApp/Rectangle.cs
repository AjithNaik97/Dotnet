﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TypeApp
{
    //Multiple interface inheritance
    public class Rectangle:Shape,IPrintable
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public void Print()
        {
            Console.WriteLine("Printing Print");
        }
    }
}
