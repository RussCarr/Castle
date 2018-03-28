using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Game : IGame
    {
    

    public Game()
    {
    }

    public Room CurrentRoom { get; set;}
    public Player CurrentPlayer { get; set;}

    public void Reset()
    {
      throw new System.NotImplementedException();
    }

    public void Setup()
    {
      throw new System.NotImplementedException();
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