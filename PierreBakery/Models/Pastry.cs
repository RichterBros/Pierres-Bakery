namespace PierreBakery.Models
{
  public class Pastry
  {
    public int UserPastryAmount { get; }
    public int PastryOrderTotal { get; set; }

    public int PastryPrice { get; set; }
    
    
    public Pastry(int inputPastry)
    {
      UserPastryAmount = inputPastry;
      PastryPrice = 2;
    }
    public int GetTotal()
    {
      int PastryDiscount = UserPastryAmount / 3 * 5;
      int PastryRemainder = UserPastryAmount % 3 * PastryPrice;
      PastryOrderTotal = PastryDiscount + PastryRemainder;

      return PastryOrderTotal;
    }
  }
}
     
      
      
     
      


