using System;

namespace garys_garage
{
    public class Ram : Vehicle
    {  // Gas powered truck
        public double FuelCapacity { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"My {MainColor} Ram drives past. *rumble*");
        }
          public override void Stop()
        {
            Console.WriteLine($"My {MainColor} Ram comes quickly to a stop.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"My {MainColor} Ram turns {direction}.");
        }
        public void RefuelTank() { }
    }
}