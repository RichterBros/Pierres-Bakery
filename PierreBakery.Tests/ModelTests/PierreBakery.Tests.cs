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
      Pastry newPastry= new Pastry("");
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
  
  }
}