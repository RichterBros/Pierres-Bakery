using System;
using System.Collections.Generic;

namespace PierreBakery.Models
{
 
  public class Pastry
  {
  public int UserPastryAmount { get; }
    public Pastry(int inputPastry)
    {
      UserPastryAmount = inputPastry;
    }
  
    public static int PastryOrderTotal(int inputPastry)
    {
    int PastryPrice = 0;
      
      if (inputPastry == 1)
      {
        PastryPrice = 2;
      }
    return PastryPrice;
    }
  
  
  }
}
  
