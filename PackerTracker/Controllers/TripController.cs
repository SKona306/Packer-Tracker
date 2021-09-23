using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers
{
  public class TripController : Controller
  {
    [HttpGet("/trips")]
    public ActionResult Index()
    {
      List<Trip> allTrips = Trip.GetAll();
      return View(allTrips);
    }

    [HttpGet("/trips/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/trips")]
    public ActionResult New(string name)
    {
      Trip myTrip = new Trip(name);
      return RedirectToAction("Index");
    }

    [HttpGet("/trips/{id}")]
    public ActionResult Show(int id)
    {
      Trip foundTrip = Trip.Find(id);
      return View(foundTrip);
    }

    [HttpPost("/trips/delete")]
    public ActionResult DeleteAll()
    {
      Trip.ClearAll();
      return View();
    }
  }
}