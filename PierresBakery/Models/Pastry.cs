using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Amount { get; set; }

    public Pastry(int amount)
    {
      Amount = amount;
    }
    public int PastryCost()
    {
      int pastryPrice = 0;
      if (Amount <= 2)
      {
         pastryPrice = Amount * 2;
      }
      else if (Amount % 3 == 0)
      {
        pastryPrice = (Amount / 3) * 5;
      }
      else
      {
        pastryPrice = ((Amount % 3) * 2) + 5;
      }
      return pastryPrice;
    }
  }
}