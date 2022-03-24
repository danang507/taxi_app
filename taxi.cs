using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi_app
{
    public class Taxi
    {
        //properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("On Duty : {0}", OnDuty);
            Console.WriteLine("Number of Passenger : {0}", NumPassenger);
            Console.WriteLine("\n");
        }

        public void PickUpPassenger()
        {
            Console.Write(DriverName);
            Console.Write(" sedang menjemput penumpang ");
            Console.WriteLine(" ");


        }

        public void DropOffPassenger()
        {
            Console.Write(DriverName);
            Console.Write(" selesai mengantar penumpang ");
            Console.WriteLine("\n");
        }

    }
}
