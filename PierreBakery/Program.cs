using System;
using PierreBakery.Models;

namespace PierreBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("-------------------------------------------------");
      Console.WriteLine("Welcome To Pierre's Bakery!");
      Console.WriteLine("Pastry: Buy 1 for $2 or 3 for $5.");
      Console.WriteLine("Bread: Buy 2, get 1 free. A single loaf costs $5.");
      Console.WriteLine("-------------------------------------------------");
      Console.WriteLine("enter amount of pastry to buy");
      int inputPastry = Int32.Parse(Console.ReadLine());
      
      Pastry pastry = new Pastry(inputPastry);
      
      Console.WriteLine("enter amount of bread to buy");
      int inputBread = Int32.Parse(Console.ReadLine());
      
      Bread bread = new Bread(inputBread);
      
      Console.WriteLine("your total for pastry is " + "$" + pastry.GetTotal());
      Console.WriteLine("your total for bread is " + "$" + bread.GetTotal());
      int GrandTotal = bread.GetTotal() + pastry.GetTotal();
      Console.WriteLine("your grand total is " + "$" + GrandTotal);
    }
  }
}
