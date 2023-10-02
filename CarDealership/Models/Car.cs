using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public int Year {get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    private static List<Car> _instances = new List<Car> { };

    public Car(int year, string make, string model)
    {
      Year = year;
      Make = make;
      Model = model;
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}