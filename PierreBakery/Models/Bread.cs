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
      if (inputBread == 1)
      {
        return 5;
      }
      else if (inputBread == 2)
      {
        return 10;
      }
      int BreadPrice;
      int BreadDeal;
      int BreadFinalPrice;

      BreadPrice = inputBread * 5;
      BreadDeal = BreadPrice / 3;
      BreadFinalPrice = BreadPrice - BreadDeal;

      return BreadFinalPrice;
    }
  }
}