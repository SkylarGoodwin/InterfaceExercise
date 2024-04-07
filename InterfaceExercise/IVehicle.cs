using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public void DisplayDetails();
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public bool FourWheelDrive {  get; set; }
        public int Year { get; set; }
    }
}
