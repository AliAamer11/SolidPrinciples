using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    public interface IGasolineVehicle : IGasolineVehicle
    {
        int FuelLength { get; }
        void FullTankByGas();
    }
}
