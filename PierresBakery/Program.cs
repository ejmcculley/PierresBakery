using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("._________________________________.");
      Console.WriteLine("|                                 |");
      Console.WriteLine("|        Little P's Bakery        |");
      Console.WriteLine("|                                 |");
      Console.WriteLine("|=================================|");
      Console.WriteLine("|                                 |");
      Console.WriteLine("|  Bread: $5 (buy 2, get 1 free)  |");
      Console.WriteLine("|                                 |");
      Console.WriteLine("|  * all bread is naturally       |");
      Console.WriteLine("|    leavened                     |");
      Console.WriteLine("|                                 |");
      Console.WriteLine("|.................................|");
      Console.WriteLine("|                                 |");
      Console.WriteLine("|  Pastries:  $2 (buy 3 for $5)   |");
      Console.WriteLine("|                                 |");
      Console.WriteLine("|  * rotating selection of        |");
      Console.WriteLine("|    classic french pastries      |");
      Console.WriteLine("|                                 |");
      Console.WriteLine("|=================================|");
      Console.WriteLine("|                                 |");
      Console.WriteLine("|           Thank You!            |");
      Console.WriteLine("|                                 |");
      Console.WriteLine("._________________________________.");

      Console.WriteLine("Welcome to Little P's Bakery!");
      Console.WriteLine("Would you like to order some bread? (Enter Yes or No)");

      Bread newBreadOrder = new Bread(0, 5);
      Pastry newPastryOrder = new Pastry(0);

      string initialBreadAnswer = Console.ReadLine();
      string breadAnswer = initialBreadAnswer.ToLower();
      if (breadAnswer == "yes")
      {
        Console.WriteLine("How many loaves would you like?");
        string stringAmount = Console.ReadLine();
        int amount = int.Parse(stringAmount);
        newBreadOrder.Amount = amount;
      }
      else 
      {
        Console.WriteLine("Watchin' those carbs eh!?");
      }

      Console.WriteLine("Would you like to order some pastries? (Enter Yes or No)");

      string initialPastryAnswer = Console.ReadLine();
      string pastryAnswer = initialPastryAnswer.ToLower();
      if (pastryAnswer == "yes")
      {
        Console.WriteLine("How many pastries would you like?");
        string stringAmount = Console.ReadLine();
        int amount = int.Parse(stringAmount);
        newPastryOrder.Amount = amount;
      }
      else 
      {
        Console.WriteLine("Don't have much of a sweet tooth eh!?");
      }

      Console.WriteLine("Thanks for coming in! Your Order Total is:");
      Console.WriteLine("$" + (newBreadOrder.BreadCost() + newPastryOrder.PastryCost()));
    }
  }
}