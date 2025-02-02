using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    public class Square : Shape
    {
        public double Height { get; set; }
        public Square(double height)
        {
            Height = height;
        }
        public override double CalculateArea()
        {
            return Height * Height;
        }
    }
}
