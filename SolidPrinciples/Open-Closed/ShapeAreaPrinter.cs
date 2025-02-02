using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    public class ShapeAreaPrinter
    {
        public Shape Shape { get; set; }
        public ShapeAreaPrinter(Shape shape)
        {
            this.Shape = shape;
        }

        public void Print()
        {
            Console.WriteLine(Shape.CalculateArea());
        }
    }
}
