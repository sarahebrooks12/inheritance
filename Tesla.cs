using System;

namespace garys_garage
{
public class Tesla : Vehicle{  // Electric car
    public double BatteryKWh { get; set; }
   
    public void ChargeBattery () {}

    public override void Drive() {
       Console.WriteLine($"My {MainColor} Tesla drives past. *crickets*");
    }
    public override void Turn (string direction) {
        Console.WriteLine($"My {MainColor} Tesla turns {direction}.");
    }
      public override void Stop(){
        Console.WriteLine($"My {MainColor} Tesla comes quietly to a stop like a ninja.");
    }
}
}