using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDD_OnThi_07_10_Cau1
{
    internal class Car
    {
       private string hangXe;
       private string namsanXuat;
       private string bienSo;
       private int giaBan;

        public string HangXe { get => hangXe; set => hangXe = value; }
        public string NamsanXuat { get => namsanXuat; set => namsanXuat = value; }
        public string BienSo { get => bienSo; set => bienSo = value; }
        public int GiaBan { get => giaBan; set => giaBan = value; }

        public Car() { }

        public Car(string hangXe, string namsanXuat, string bienSo, int giaBan)
        {
            this.HangXe = hangXe;
            this.NamsanXuat = namsanXuat;
            this.BienSo = bienSo;
            this.GiaBan = giaBan;          
        }
    }
    
}
