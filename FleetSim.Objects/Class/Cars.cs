using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FleetSim.Objects;
using FleetSim.Objects.Interface;

namespace FleetSim.Objects.Class
{
    public class Cars : Vehicle, ICars
    {
        int year;
        string Model;

        public Cars (String ModelName)
        {
            Model = ModelName;

            
        }
        public Cars (string ModelName, string CarColor, int Year)
        {
            year = Year;
            Model = ModelName;
            VehicleColor = CarColor;

        }
        public void TuneUp() {
            int Result = (Mileages - LastServicedMileages);
            if (Result >= 30000)
            {
                LastServicedMileages = Mileages;
                LastServicedDate = DateTime.Now;
                Console.WriteLine("Vehicle tuned up at " + LastServicedMileages + "miles on " + LastServicedDate + " " + Model);
                if (Result >= 100000)
                {
                    RebulidEngine();
                }

            }

        }
        public void RebulidEngine()
        {
            Mileages = 0;
            LastServicedMileages = 0;
            Console.WriteLine("Engine rebuild on "+ LastServicedDate + "for " + Model);


        }

    }

    
}
