namespace CastleGrimtol.Project.Rooms

{
  public class Lobby : IRoom 
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string Directions { get; set; }
    // public List<Item> Items { get; set; }
    // public bool DirectionN { get; set; }
    // public bool DirectionE { get; set; }
    // public bool DirectionS { get; set; }
    // public bool DirectionW { get; set; }
    public Lobby()
    {
      // Name = "Lobby";
      // Description = "You have found your way into the castle through a secret tunnel but you can't turn back. The tunnel collapsed and now you will need to find a way to disguise yourself and kill the Dark Lord. We don't know exactly how so you'll need to use your wit and cunning to think of something.";
      // Directions = "[(n)orth,(s)outh,(e)ast]";
      // DirectionN = true;
      // DirectionE = true;
      // DirectionS = true;
      // DirectionW = false;
    }
    public void story(Game game)
    {
      System.Console.WriteLine("You have found your way into the castle through a secret tunnel but you can't turn back. The tunnel collapsed and now you will need to find a way to disguise yourself and kill the Dark Lord. We don't know exactly how so you'll need to use your wit and cunning to think of something.");
      System.Console.WriteLine("[(n)orth,(s)outh,(e)ast]");
      directions();

    }
    public void directions()
    {
      string playerChoise = System.Console.ReadLine().ToLower();
      switch (playerChoise)
      {
        case "n":
          System.Console.WriteLine("north");
          Barracks CurrentRoom = new Barracks();
          // CurrentRoom.story(); 
          break;
        case "s":
          System.Console.WriteLine("south");
          break;
        case "e":
          System.Console.WriteLine("east");
          break;
        case "look":
          look();
          break;
        case "help":
          break;
        case "quit":
          break;
        case "inventory":
         Game. CurrentPlayer.inventory();
          break;
        default:
          directions();
          break;
      }
    }



    public void look()
    {
      System.Console.WriteLine("You look around and see the collaped tunnel you climbed out of. I got luckly there now on to my mission!");
      Items.Key key = new Items.Key("silver");
      directions();
    }

    // public void useItem(List<Item> item)



  }


}

