using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Amount { get; set; }
    public int Price { get; set; }

    public Bread(int amount, int price)
    {
      Amount = amount;
      Price = 5;
    }
    public int BreadCost()
    {
      return Amount * Price;
    }
  }
}