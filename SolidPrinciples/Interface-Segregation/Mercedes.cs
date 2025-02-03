using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    public class Mercedes : IGasolineVehicle
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Model { get; set; }

        public int FuelLength { get; set; }

        public void Drive()
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
