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
  }
}