using System;
using System.Collections.Generic;
using PierreBakery.Models;

namespace PierreBakery {
  public class Program
  {
    public static void Main()
    {
  
  Console.WriteLine("enter amount of pastry to buy");
  int inputPastry = Int32.Parse(Console.ReadLine());
  
  Console.WriteLine("your total is " + Pastry.PastryOrderTotal(inputPastry));
  
    }
  }
}