using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    public interface IGasolineVehicle
    {
        string Name { get; }
        string Description { get; }
        string Model { get; }

        void Drive();
        void Park();
    }
}
