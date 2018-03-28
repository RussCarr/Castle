using System;
using System.Collections.Generic;
using CastleGrimtol.Project;

namespace CastleGrimtol
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.Clear();
      System.Console.WriteLine("Brave Young Warrior our forces are failing and the enemy grows stronger");
      System.Console.WriteLine("everyday. I fear if we don't act now our people will be driven from their");
      System.Console.WriteLine("homes. These dark times have left us with one final course of action. We");
      System.Console.WriteLine("must cut the head off of the snake by assasinating the Dark Lord of Grimtol...");
      System.Console.WriteLine("Our sources have identified a small tunnel that leads into the rear of the");
      System.Console.WriteLine("castle.");
      System.Console.WriteLine();
      System.Console.WriteLine();
      System.Console.WriteLine("Do you want to play a game");
      string choise = System.Console.ReadLine().ToLower();

      switch (choise)
      {
      case "y":
        System.Console.WriteLine("What is your name?");
      string playerName = System.Console.ReadLine().ToLower();
        setup(playerName)
        break;
      case "n":
        break;
        default:
        break;

      }

      // Game app = new Game();
      // User jake = new User("Jake", "MarkIsAwesome");
      // User mark = new User("Mark", "IKnow");
      // User bryce = new User("Bryce", "IHeartBetos");

      //     //Add Users to Dictionary
      //     app.UsersTable.Add("jake", jake);
      //     app.UsersTable.Add("mark", mark);
      //     app.UsersTable.Add("bryce", bryce);

      //     app.Start();
      //   }
      //   app.Setup()
      //     System.Console.WriteLine("asdf");

      //   var items = new List<Project.IItem>();

      //   Key silverKey = new Key("Silver Key");
      // //   new Hammer()

      //     System.Console.WriteLine();
      //     silverKey.use ();
      //     System.Console.ReadLine();
    }
  }
}
