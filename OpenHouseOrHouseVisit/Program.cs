using System;

namespace OpenHouseOrHouseVisit
{
    class Program
    {
        public static void Main(string[] args)
        {
            House house1 = new House();
            house1.Address = "123 Main Street";

            House house2 = new House();
            house1.Address = "999 5th St";

            house1.RingDoorbell();
            house2.RingDoorbell();


        }
    }

    class House
    {
        public string Address { get; set; }
        public void RingDoorbell()
        {
            Console.WriteLine("Ding Dong! Is anyone home at " + Address + "?");
        }
    }
}
