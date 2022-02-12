using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadOrder()
    {
      Bread newBreadOrder = new Bread(1, 5);
      Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
    }
    [TestMethod]

    public void BreadCost()
    {
      Bread newBreadOrder = new Bread(2, 5);
      newBreadOrder.BreadCost();
      Assert.AreEqual(10, newBreadOrder.BreadCost());
    }
  }
}