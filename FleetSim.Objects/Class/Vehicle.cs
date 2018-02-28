using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetSim.Objects.Class
{
    
    
       // enum Color:byte {Red, White, Blue }
    
     public class Vehicle
     {
        protected Guid VIN;
        protected int Mileages;
        protected string VehicleColor;
        protected DateTime LastServicedDate;
        protected int LastServicedMileages;

        public int MileagNbr
        {
            get { return Mileages;  }
            set { Mileages = value; }
        }
        public Guid VinNbr
        {
            get { return VIN; }
            set { VIN = value; }
        }

    }
    

}
