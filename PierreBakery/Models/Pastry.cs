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
  }
}
