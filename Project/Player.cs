using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
  public class Player : IPlayer
  {
    public string PlayerName { get; set; }
    public int Pscore { get; set; }
    public string Pinventory { get; set; }
    public List<Item> Inventory { get; set; }

    public Player(string playerName, int playerScore, string playerInv)
    {
      PlayerName = playerName;
      Pscore = playerScore;
      Pinventory = playerInv;
    }
    public void score()
    {
      Console.WriteLine("Your current Score is " + this.Pscore);
    }
    public void inventory()
    {

      Console.WriteLine("Your current stuff in your bag is " + this.Pinventory);
    }

  }
}