using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryOrder()
    {
      Pastry newPastryOrder = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
    }
    public void PastryCost()
    {
      Pastry newPastryOrder = new Pastry(6);
      newPastryOrder.PastryCost();
      Assert.AreEqual(10, newPastryOrder.PastryCost());
    }
  }
}