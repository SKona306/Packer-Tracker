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

    
    
  }
}

