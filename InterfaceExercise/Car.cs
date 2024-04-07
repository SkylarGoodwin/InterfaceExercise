using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : ICompany, IVehicle
    {
        public int NumberOfSeats { get; set; }
        public bool Electric {  get; set; }
        public bool Convertable { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors {  get; set; }
        public bool FourWheelDrive {  get; set; }
        public int Year {  get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"the {Model} {Year} from {Make} has {NumberOfDoors} doors, {NumberOfSeats} seats, {NumberOfWheels} wheels.");
            Console.WriteLine($"Electric: {Electric}, Convertable: {Convertable}, Four Wheel Drive: {FourWheelDrive}");
            Console.WriteLine("");
        }
    }
}
