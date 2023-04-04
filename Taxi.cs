using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Taxi
    {
        public string DriverName { get; set; }
        public string OnDuty { get; set; }
        public float NumPassenger { get; set; }


        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName);
            Console.WriteLine("On Duty: {0}", OnDuty);
            Console.WriteLine("Number Passenger: {0}", NumPassenger);
            
        }

        public void PickUpPassenger()
        {

            Console.WriteLine("{0} sedang mengantar penumpang\n", DriverName);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} sedang mengantar penumpang", DriverName);
        }
    }
}
