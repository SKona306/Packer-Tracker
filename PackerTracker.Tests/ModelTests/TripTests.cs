using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System.Collections.Generic;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class TripTests : IDisposable
  {
    
    public void Dispose()
    {
      Trip.ClearAll();
    }

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
      string result = testTrip.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_TripId_Int()
    {
      string name = "name";
      Trip newTrip = new Trip(name);
      int result = newTrip.Id;
      Assert.AreEqual(1, result);
    }
  }
}

