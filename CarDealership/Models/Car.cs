using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public int Year {get; set; }
    public string Make { get; set; }

    public Car(int year, string make)
    {
      Year = year;
      Make = make;
    }
  }
}