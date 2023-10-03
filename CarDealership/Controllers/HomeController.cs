using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      Car starterCar = new Car(1970, "Chevrolet", "Impala");
      return View(starterCar);
    }

    [Route("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

  }
}