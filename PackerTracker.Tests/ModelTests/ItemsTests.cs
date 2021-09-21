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
  }
}