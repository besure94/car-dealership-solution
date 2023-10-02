using CarDealership.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace CarDealership.Tests
{
  [TestClass]
  public class CarTests
  {
    [TestMethod]
    public void CarConstructor_CreatesInstanceOfCar_Car()
    {
      Car newCar = new Car(1968, "Chevrolet");
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }

    [TestMethod]
    public void GetYear_ReturnsYear_Int()
    {
      int year = 1970;
      Car newCar = new Car(year, "Chevrolet");
      int result = newCar.Year;
      Assert.AreEqual(year, result);
    }

    [TestMethod]
    public void SetYear_SetYear_Int()
    {
      int year = 1970;
      Car newCar = new Car(year, "Chevrolet");
      int updatedYear = 1999;
      newCar.Year = updatedYear;
      int result = newCar.Year;
    }

    [TestMethod]
    public void GetMake_ReturnsMake_String()
    {
      string make = "Chevrolet";
      Car newCar = new Car(1970, make);
      string result = newCar.Make;
      Assert.AreEqual(make, result);
    }
  }
}