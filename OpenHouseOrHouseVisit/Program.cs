using System; // This is a using Directive

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

            Console.WriteLine("There are " + House.TotalNumberOfHousesBuilt + " houses.");
        }
    }

    class House
    {
        public House()
        {
            TotalNumberOfHousesBuilt += 1;
        }
        public string Address { get; set; }
        public static int TotalNumberOfHousesBuilt { get; set; }
        public void RingDoorbell()
        {
            Console.WriteLine("Ding Dong! Is anyone home at " + Address + "?");
        }
    }
}
