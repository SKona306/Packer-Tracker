using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System.Collections.Generic;
using System;

namespace PackerTracker.TestTools
{
  [TestClass]
  public class PackerTrackerTests 
  {
    [TestMethod]
    public void TripConstructor_CreatesInstanceOfTrip_Trip()
    {
      Trip testTrip = new Trip("name");
      Assert.AreEqual(typeof(Trip), testTrip.GetType());
    }

    [TestMethod]
    public void TripConstructor_ReturnsCorrectTripName_String()
    {
      string name = "bicycle";
      Trip testTrip = new Trip(name);
      string result = testTrip.TripName;
      Assert.AreEqual(name, result);
    }
    
  }
}

