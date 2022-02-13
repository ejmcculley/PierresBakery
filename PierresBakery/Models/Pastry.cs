using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Amount { get; set; }
    public int Price { get; set; }

    public Pastry(int amount, int price)
    {
      Amount = amount;
      Price = price;
    }
  }
}