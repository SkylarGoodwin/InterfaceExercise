using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : ICompany, IVehicle
    {
        public int NumberOfSeats { get; set; }
        public double CargoSpace { get; set; }
        // no, car go road
        public bool TintedWindows { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public bool FourWheelDrive { get; set; }
        public int Year { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"the {Model} {Year} from {Make} has {NumberOfDoors} doors, {NumberOfSeats} seats, {NumberOfWheels} wheels, {CargoSpace} feet of cargo space");
            Console.WriteLine($"Tinted Windows: {TintedWindows}, Four wheel drive: {FourWheelDrive}");
            Console.WriteLine("");
        }
    }
}
