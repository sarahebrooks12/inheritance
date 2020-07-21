using System;
using System.Collections.Generic;

// Practice: Custom Colors and Sounds
// -- Move all common properties in your vehicles to a new Vehicle class.
// -- Create an instance of each vehicle.
// -- Define a different value for each vehicle's properties.
// -- Create a Drive() method in the Vehicle class. 
// -- Override the Drive() method in all the other vehicle classes. Include the vehicle's color in the message (i.e. "The blue Ram drives past. RRrrrrrummbbble!").
// -- Create a Turn(string direction) mathod, and a Stop() method on Vehicle. Define a basic implementation of each.
// -- Override all three of those methods on some of the vehicles. For example, the Stop() method for a plane would be to output the message "The white Cessna rolls to a stop after rolling a mile down the runway."
// -- Make your vehicle instances perform all three behaviors.

namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero myMotorcycle = new Zero();
            myMotorcycle.MainColor = "red";
            myMotorcycle.MaximumOccupancy = "1";
            myMotorcycle.BatteryKWh = 5;

            Cessna myPlane = new Cessna();
            myPlane.FuelCapacity = 105.5;
            myPlane.MainColor = "white";
            myPlane.MaximumOccupancy = "14";

            Ram myTruck = new Ram ();
            myTruck.FuelCapacity = 15;
            myTruck.MaximumOccupancy = "5";
            myTruck.MainColor = "green";

            Tesla myCar = new Tesla();
            myCar.BatteryKWh = 18.5;
            myCar.MainColor = "black";
            myCar.MaximumOccupancy = "2";

            List<Vehicle> garage = new List<Vehicle>();
            garage.Add(myMotorcycle);
            garage.Add(myTruck);
            garage.Add(myCar);
            garage.Add(myPlane);

            myPlane.Drive();
            myCar.Drive();
            myMotorcycle.Drive();
            myTruck.Drive();
            
            myTruck.Turn("left");
            myCar.Turn("right");
            myMotorcycle.Turn("slightly left");
            myPlane.Turn("a bit right");

            myTruck.Stop();
            myCar.Stop();
            myPlane.Stop();
            myMotorcycle.Stop();


            

            Console.WriteLine();

        }
    }
}
