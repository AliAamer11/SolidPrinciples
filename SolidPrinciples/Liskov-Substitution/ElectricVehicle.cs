using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    public class ElectricVehicle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Checking battery and starting electric motor.");
        }
    }
}
