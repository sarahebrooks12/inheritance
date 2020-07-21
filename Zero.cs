using System;

namespace garys_garage

{
    public class Zero : Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        public void ChargeBattery() { }
        public override void Drive()
        {
            Console.WriteLine($"My {MainColor} Zero drives past. *revvv*");
        }
        public override void Stop()
        {
            Console.WriteLine($"My {MainColor} Zero comes roaring to a stop.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"My {MainColor} Zero turns {direction}.");
        }
    }
}