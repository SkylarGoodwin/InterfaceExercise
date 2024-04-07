using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            // Done Create 2 Interfaces called IVehicle & ICompany

            //Done Create 3 classes called Car , Truck , & SUV

            // Done In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            // Done In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            // Done In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Done Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            var myCar = new Car();
            myCar.Convertable = true;
            myCar.FourWheelDrive = true;
            myCar.NumberOfSeats = 4;
            myCar.NumberOfWheels = 4;
            myCar.NumberOfDoors = 4;
            myCar.Year = 2000;
            myCar.Electric = false;
            myCar.Make = "Honda";
            myCar.Model = "Accord";

            var myTruck = new Truck();
            myTruck.Year = 2001;
            myTruck.NumberOfWheels = 4;
            myTruck.FourWheelDrive = true;
            myTruck.Torque = 410;
            myTruck.Make = "Ford";
            myTruck.Model = "F150";
            myTruck.AreaBed = 25.25;
            myTruck.Diesel = true;
            myTruck.NumberOfDoors = 2;

            var mySUV = new SUV();
            mySUV.NumberOfDoors = 4;
            mySUV.NumberOfWheels= 4;
            mySUV.NumberOfSeats = 6;
            mySUV.FourWheelDrive= true;
            mySUV.CargoSpace = 25.25;
            mySUV.Year = 2002;
            mySUV.TintedWindows = true;
            mySUV.Make = "Tesla";
            mySUV.Model = "Y";

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            myCar.DisplayDetails();
            mySUV.DisplayDetails();
            myTruck.DisplayDetails();
        }
    }
}
