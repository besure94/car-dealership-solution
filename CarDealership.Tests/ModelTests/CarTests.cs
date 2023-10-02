using CarDealership.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarDealership.Tests
{
  [TestClass]
  public class CarTests
  {
    [TestMethod]
    public void CarConstructor_CreatesInstanceOfCar_Car()
    {
      Car newCar = new Car();
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }
  }
}