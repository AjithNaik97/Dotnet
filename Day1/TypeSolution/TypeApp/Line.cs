using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TypeApp
{
    //Multiple interface inheritance
    public sealed class Line: Shape, IPrintable
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        //sealed keyword is used to block inheritance
        public override void Draw()
        {
            Console.WriteLine("Drawing Line");
            Console.WriteLine(this.ShapeColor + " " + this.Width);
        }

        public void Print()
        {
            Console.WriteLine("Printing Line");
        }
    }
}
