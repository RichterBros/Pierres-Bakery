namespace PierreBakery.Models
{
 
 public class Bread
  {
 public int UserBreadAmount { get; }
    public Bread(int inputBread)
    {
      UserBreadAmount = inputBread;
    }

    public static int BreadOrderTotal(int inputBread)
  
  {
    int BreadPrice;
    int BreadDeal;
    int BreadFinalPrice;
    
    BreadPrice = inputBread *5;
    BreadDeal = BreadPrice /3;
    BreadFinalPrice = BreadDeal - BreadPrice;
    
    return BreadFinalPrice;
  }
  }
}