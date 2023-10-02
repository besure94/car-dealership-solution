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
      Car newCar = new Car(1968, "Chevrolet", "Impala");
      Assert.AreEqual(typeof(Car), newCar.GetType());
    }

    [TestMethod]
    public void GetYear_ReturnsYear_Int()
    {
      int year = 1970;
      Car newCar = new Car(year, "Chevrolet", "Impala");
      int result = newCar.Year;
      Assert.AreEqual(year, result);
    }

    [TestMethod]
    public void SetYear_SetYear_Int()
    {
      int year = 1970;
      Car newCar = new Car(year, "Chevrolet", "Impala");
      int updatedYear = 1999;
      newCar.Year = updatedYear;
      int result = newCar.Year;
    }

    [TestMethod]
    public void GetMake_ReturnsMake_String()
    {
      string make = "Chevrolet";
      Car newCar = new Car(1970, make, "Impala");
      string result = newCar.Make;
      Assert.AreEqual(make, result);
    }

    [TestMethod]
    public void SetMake_SetYear_String()
    {
      string make = "Toyota";
      Car newCar = new Car(1999, make, "Civic");
      string updatedMake = "Honda";
      newCar.Make = updatedMake;
      string result = newCar.Make;
    }

    [TestMethod]
    public void GetModel_ReturnsModel_String()
    {
      string model = "Impala";
      Car newCar = new Car(1970, "Chevrolet", model);
      string result = newCar.Model;
      Assert.AreEqual(model, result);
    }
  }
}