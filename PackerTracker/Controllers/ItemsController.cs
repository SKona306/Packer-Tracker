using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;
using System.Collections.Generic;

namespace PackerTracker.Controllers 
{
  public class ItemController : Controller
  {

    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Item> allItems = Item.GetAll();
      return View(allItems);

    }
    [HttpGet("/items/new")]
     public ActionResult New()
    {
     return View();
    }

   [HttpPost("/items")]
    public ActionResult New(string name, string description)
    {
      Item myItem = new Item(name, description);
      return RedirectToAction("Index");
    }

   [HttpPost("/items/delete")]
   public ActionResult DeleteAll()
   {
    Item.ClearAll();
    return View();
   }
  }
}

