using System.Collections.Generic;

namespace CastleGrimtol.Project
{
  public class Game : IGame
  {
    public Room CurrentRoom { get; set; }
    public Player CurrentPlayer { get; set; }

    public void Reset()
    {
      Setup();
    }
    public void Setup()
    {
    
      System.Console.Clear();
      {
        System.Console.WriteLine("Brave Young Warrior our forces are failing and the enemy grows stronger");
        System.Console.WriteLine("everyday. I fear if we don't act now our people will be driven from their");
        System.Console.WriteLine("homes. These dark times have left us with one final course of action. We");
        System.Console.WriteLine("must cut the head off of the snake by assasinating the Dark Lord of Grimtol...");
        System.Console.WriteLine("Our sources have identified a small tunnel that leads into the lobby of the");
        System.Console.WriteLine("castle.");
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine("Do you want to help save us?");
        string choise = System.Console.ReadLine().ToLower();

        switch (choise)
        {
          case "y":
            System.Console.WriteLine("What is your name?");
            string playerName = System.Console.ReadLine().ToLower();
            Player player = new Player(playerName);
            List<Item> Inventory = new List<Item>();
            // Item item = new Item();
            break;
          case "n":
            break;
          default:
            Setup();
            break;
        }

      }
    }
    public void UseItem(string itemName)
    {
      throw new System.NotImplementedException();
    }

    //   var items = new List<Project.IItem>();

    //   Key silverKey = new Key("Silver Key");
    // //   new Hammer()

    //     System.Console.WriteLine();
    //     silverKey.use ();
    //     System.Console.ReadLine();
  }


}