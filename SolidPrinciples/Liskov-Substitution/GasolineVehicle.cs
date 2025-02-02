using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    public class GasolineVehicle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Starting engine using ignition and fuel.");
        }
    }
}
