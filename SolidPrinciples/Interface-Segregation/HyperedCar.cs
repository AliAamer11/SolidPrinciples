namespace Interface_Segregation
{
    public class HyperedCar : IGasolineVehicle, IElectricVehicle
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Model { get; set; }

        public int FuelLength { get; set; }

        public int BatteryLength { get; set; }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void FullTankByElectricity()
        {
            throw new NotImplementedException();
        }

        public void FullTankByGas()
        {
            throw new NotImplementedException();
        }

        public void Park()
        {
            throw new NotImplementedException();
        }
    }
}
