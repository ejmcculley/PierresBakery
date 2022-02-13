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
      Console.WriteLine("Would you like to order some bread? (Type Y for Yes, N for No");

      string breadAnswer = Console.ReadLine();
      // if (breadAnswer != "Y" || breadAnswer != "N")
      // {
      //   Console.WriteLine("Please enter Y for Yes or N for No");
      // }
      if (breadAnswer == "Y")
      {
        Console.WriteLine("How many loaves would you like?");
        string stringAmount = Console.ReadLine();
        int amount = int.Parse(stringAmount);
        Bread newBreadOrder = new Bread(amount, 5);
      }
      else 
      {
        Console.WriteLine("Watchin' those carbs eh!?");
      }

      Console.WriteLine("Would you like to order some pastries? (Type Y for Yes, N for No");

      string pastryAnswer = Console.ReadLine();
      // if (pastryAnswer != "Y" || "N")
      // {
      //   Console.WriteLine("Please enter Y for Yes or N for No");
      // }
      if (pastryAnswer == "Y")
      {
        Console.WriteLine("How many pastries would you like?");
        string stringAmount = Console.ReadLine();
        int amount = int.Parse(stringAmount);
        Pastry newPastryOrder = new Pastry(amount);
      }
      else
      {
        Console.WriteLine("Don't have much of a sweet tooth eh!?");
      }

      Console.WriteLine("Thanks for coming in! Your Order Total is:");
      Console.WriteLine(newBreadOrder.BreadCost() + newPastryOrder.PastryCost());
    }
  }
}