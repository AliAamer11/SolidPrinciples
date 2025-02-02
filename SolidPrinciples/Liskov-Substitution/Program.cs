namespace Liskov_Substitution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle = new GasolineVehicle();
            vehicle.StartEngine();

            vehicle = new ElectricVehicle();
            vehicle.StartEngine();

            Console.ReadKey();
        }
    }
}
