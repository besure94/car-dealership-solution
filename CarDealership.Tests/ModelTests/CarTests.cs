using CarDealership.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Http.Features;

namespace CarDealership.Tests
{
  [TestClass]
  public class CarTests : IDisposable
  {
    public void Dispose()
    {
      Car.ClearAll();
    }

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
      Assert.AreEqual(updatedYear, result);
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
      Assert.AreEqual(updatedMake, result);
    }

    [TestMethod]
    public void GetModel_ReturnsModel_String()
    {
      string model = "Impala";
      Car newCar = new Car(1970, "Chevrolet", model);
      string result = newCar.Model;
      Assert.AreEqual(model, result);
    }

    [TestMethod]
    public void SetModel_SetModel_String()
    {
      string model = "Impala";
      Car newCar = new Car(1970, "Chevrolet", model);
      string updatedModel = "Camaro";
      newCar.Model = updatedModel;
      string result = newCar.Model;
      Assert.AreEqual(updatedModel, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyListOfCars_CarList()
    {
      List<Car> newList = new List<Car> { };
      List<Car> result = Car.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsCars_CarList()
    {
      int year01 = 1970;
      int year02 = 1999;
      int year03 = 2023;
      string make01 = "Chevrolet";
      string make02 = "Toyota";
      string make03 = "Lincoln";
      string model01 = "Impala";
      string model02 = "Corolla";
      string model03 = "Navigator";
      Car newCar01 = new Car(year01, make01, model01);
      Car newCar02 = new Car(year02, make02, model02);
      Car newCar03 = new Car(year03, make03, model03);
      List<Car> newList = new List<Car> { newCar01, newCar02, newCar03 };
      List<Car> result = Car.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}