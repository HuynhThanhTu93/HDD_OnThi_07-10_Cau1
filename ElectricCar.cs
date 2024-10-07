using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDD_OnThi_07_10_Cau1
{
    internal class ElectricCar : Car
    {
        private int batteryCapacity;

        public int BatteryCapacity { get => BatteryCapacity; set => BatteryCapacity = value; }

        public ElectricCar() { }

        public ElectricCar(string hangXe, string namsanXuat, string bienSo, int giaBan, int batteryCapacity) : base(hangXe,namsanXuat,bienSo,giaBan)
        {          
            this.BatteryCapacity = batteryCapacity;
        }
    }
}
