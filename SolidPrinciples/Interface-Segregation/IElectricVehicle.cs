﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation
{
    public interface IElectricVehicle : IGasolineVehicle
    {
        int BatteryLength { get; }
        void FullTankByElectricity();
    }
}
