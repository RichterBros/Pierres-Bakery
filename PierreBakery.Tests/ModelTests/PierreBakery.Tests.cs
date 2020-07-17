using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using PierreBakery.Models;

namespace PierreBakery.Tests
{
  [TestClass]
  public class ClassTests
  {
[TestMethod]
    public void PastryConstructor_CreatesInstanceOfClass_Pastry()
    {
      Pastry newPastry= new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
  
  [TestMethod]
    public void BreadConstructor_CreatesInstanceOfClass_Bread()
    {
      Bread newBread= new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
  
  [TestMethod]
    public void PastryOrderTotal_ReturnsNumber()
    {
      int testNumber =2;
      Pastry newPastry= new Pastry(1);
      int resultNumber = Pastry.PastryOrderTotal(1);
      Assert.AreEqual(testNumber, resultNumber);
    }
  
   [TestMethod]
    public void PastryOrderTotal_ReturnsNumberWithDiscount()
    {
      int testNumber =2;
      Pastry newPastry= new Pastry(6);
      int resultNumber = Pastry.PastryOrderTotal(7);
      Assert.AreEqual(testNumber, resultNumber);
    }
  }
}