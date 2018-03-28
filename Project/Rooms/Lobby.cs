using System.Collections.Generic;

namespace CastleGrimtol.Project.Rooms
{
  public class Lobby : IRoom
  {
    public string Name { get; set; }
    public string Description { get; set; }
    // public List<Item> Items { get; set; }

    public Lobby()
    {
      Name = "Lobby";
      Description = "asdf";
    }

    public void look()
    {
      System.Console.WriteLine("You have found your way into the castle through a secret tunnel but you can't turn back. The tunnel collapsed and now you will need to find a way to disguise yourself and kill the Dark Lord. We don't know exactly how so you'll need to use your wit and cunning to think of something.");
    }

    // public void UseItem(Item item)
    // {
   
    // }
  }
}

