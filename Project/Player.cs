using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
  public class Player : IPlayer
  {
    public string PlayerName { get; set; }
   
    public Player (string playerName)
    {
      PlayerName = playerName;
    }
       public void Score (int Score)
    {
      Console.WriteLine("Your current Score is " + Score);
    }
    // public void Inventory (string inventory)
    // {
    //   inventory = null;

    // }

  }
}