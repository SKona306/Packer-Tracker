using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System.Collections.Generic;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class ItemsTests 
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("hello", "this is hello");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void ItemConstructor_CreatesObjectWithName_String()
    {
      string name = "bicycle trip";
      string tripDescription = "this is a trip around a mountain";
      Item newItem = new Item(name, tripDescription);
      string result = newItem.Name;
      Assert.AreEqual(name, result);
    }

     [TestMethod]
    public void ItemConstructor_CreatesObjectWithDescription_String()
    {
      string name = "bicycle trip";
      string tripDescription = "this is a trip around a mountain";
      Item newItem = new Item(name, tripDescription);
      string result = newItem.Description;
      Assert.AreEqual(tripDescription, result);
    }
  }
}