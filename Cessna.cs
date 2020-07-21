using System;

namespace garys_garage
{
    public class Cessna : Vehicle
    {  // Propellor light aircraft
        public double FuelCapacity { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"My {MainColor} Cessna flies past. *zoom*");
        }
          public override void Stop()
        {
            Console.WriteLine($"My {MainColor} Cessna rolls to a stop on the runway.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"My {MainColor} Zero veers {direction}.");
        }
        public void RefuelTank() { }
    }
}