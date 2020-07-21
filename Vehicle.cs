using System;

namespace garys_garage
{
 public class Vehicle
{
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    // public void Drive () {
    //     Console.WriteLine("Vroom");
    // }
// virtual = allows you to override
    public virtual void Drive (){
        Console.WriteLine("Vroom!");
    }
    public virtual void Turn (string direction) {
        Console.WriteLine($"The vehicle turns {direction}.");
    }
    public virtual void Stop(){
        Console.WriteLine($"The vehicle comes to a stop.");
    }
}
}