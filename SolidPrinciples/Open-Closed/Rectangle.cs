namespace Open_Closed
{
    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Height * Width;
        }
    }
}
