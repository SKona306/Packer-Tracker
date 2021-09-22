using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System.Collections.Generic;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class ItemsTests : IDisposable
  {

    public void Dispose()
    {
      Item.ClearAll();
    }
    
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

    [TestMethod]
    public void GetAllMethod_ShowsEmptyList_ItemList()
    {
      //Arrange
      List<Item> newList = new List<Item> {};
      //Act
      List<Item> result = Item.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}