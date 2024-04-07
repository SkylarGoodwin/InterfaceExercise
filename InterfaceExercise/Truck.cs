using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public double Torque { get; set; }
        public bool Diesel { get; set; }
        public double AreaBed { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public bool FourWheelDrive { get; set; }
        public int Year { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"the {Model} {Year} from {Make} has {NumberOfDoors} doors, {NumberOfWheels} wheels, {Torque} pounds of torque, {AreaBed} square foot bed");
            Console.WriteLine($"Diesel: {Diesel}, Four Wheel Drive: {FourWheelDrive}");
            Console.WriteLine("");
        }
    }
}
