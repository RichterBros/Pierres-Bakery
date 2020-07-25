namespace PierreBakery.Models
{
  public class Bread
  {
    public int UserBreadAmount { get; }
    public int BreadFinalPrice { get; set; }
    public Bread(int inputBread)
    {
      UserBreadAmount = inputBread;
    }
    public int GetTotal()

    {
      if (UserBreadAmount == 1)
      {
        return 5;
      }
      else if (UserBreadAmount == 2)
      {
        return 10;
      }
     
      int BreadPrice = UserBreadAmount * 5;
      int BreadDeal = BreadPrice / 3;
      int BreadFinalPrice = BreadPrice - BreadDeal;

      return BreadFinalPrice;
    }
  }
}
