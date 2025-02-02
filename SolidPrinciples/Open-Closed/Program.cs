namespace Open_Closed
{
    // open for extension but closed for modification
    //this can be implement by abstraction
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Square(4),
                new Square(6),
                new Rectangle(4, 8),
                new Rectangle(10, 20)
            };

            foreach (Shape shape in shapes)
            {
                ShapeAreaPrinter shapeAreaPrinter = new ShapeAreaPrinter(shape);
                shapeAreaPrinter.Print();
            }
            Console.ReadKey();
        }
    }
}
