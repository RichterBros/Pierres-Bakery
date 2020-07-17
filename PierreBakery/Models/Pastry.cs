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
      int PastryPrice = 2;
      int PastryDiscount;
      int PastryRemainder;
      int PastryOrderTotal;

      PastryDiscount = inputPastry / 3 * 5;
      PastryRemainder = inputPastry % 3 * PastryPrice;
      PastryOrderTotal = PastryDiscount + PastryRemainder;

      return PastryOrderTotal;
    }
  }
}

