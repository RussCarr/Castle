using System.Collections.Generic;
using CastleGrimtol.Project.Rooms;

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
            Player CurrentPlayer = new Player(playerName, 0, "Currently Nothing");
            createItems();
            createRooms();
            // List<Item> Inventory = new List<Item>();
            // Lobby CurrentRoom = new Lobby();
            // Inventory.Add(Items.Key)
            // CurrentRoom.story();
            // CurrentPlayer.inventory();
            break;
          case "n":
            break;
          default:
            Setup();
            break;
        }
      }
    }
    public void createItems()
    {

      Item key = new Item("key", "a silver key");
      Item brokenlock = new Item("broken lock", "a broken lock");
      Item uniform = new Item("uniform", "a guards uniform");
      Item hammer = new Item("hammer", "a hammer");
      Item overcoat = new Item("overcoat", "a messenger overcoat");
      Item note = new Item("note", "a note");
      Item vial = new Item("vial", "a vial of poison");
    }
    public void createRooms()
    {
      Room Barracks = new Room();
      Room CaptainsQuarters = new Room();
      Room CastleCourtyards = new Room();
      Room CouncilRoom = new Room();
      Room Dungenon = new Room();
      Room GuardRoom = new Room();
      Room Lobby = new Room();
      Room NorthHallway = new Room();
      Room SouthHallway = new Room();
      Room Squiretower = new Room();
      Room ThroneRoom = new Room();

    }



    //   var items = new List<Project.IItem>();

    //   Key silverKey = new Key("Silver Key");
    // //   new Hammer()

    //     System.Console.WriteLine();
    //     silverKey.use ();
    //     System.Console.ReadLine();
  }


}