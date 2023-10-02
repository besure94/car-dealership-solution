using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public int Year {get; set; }
    public string Make { get; set; }
    public string Model { get; }

    public Car(int year, string make, string model)
    {
      Year = year;
      Make = make;
      Model = model;
    }
  }
}