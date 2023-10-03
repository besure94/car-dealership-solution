using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.Features;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(int year, string make, string model)
    {
      Car newCar = new Car(year, make, model);
      return RedirectToAction("Index");
    }

    [HttpPost("/cars/delete")]
    public ActionResult DeleteAll()
    {
      Car.ClearAll();
      return View();
    }

  }
}