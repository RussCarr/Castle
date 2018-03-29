using System.Collections.Generic;

namespace CastleGrimtol.Project.Rooms
{
  public class Barracks : IRoom
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public string Directions { get; set; }
    // public List<Item> Items { get; set; }
    public bool DirectionN { get; set; }
    public bool DirectionE { get; set; }
    public bool DirectionS { get; set; }
    public bool DirectionW { get; set; }
    public Barracks()
    {
      Name = "Lobby";
      Description = "You see a room with several sleeping guards, The room smells of sweaty men. The bed closest to you is empty and there are several uniforms tossed about.";
      Directions = "(s)outh";
      DirectionN = false;
      DirectionE = false;
      DirectionS = true;
      DirectionW = false;
    }
    public void directions()
    {
      System.Console.WriteLine("[(n)orth,(s)outh,(e)ast]");
      string playerChoise = System.Console.ReadLine().ToLower();
      switch (playerChoise)
      {

        case "s":
          System.Console.WriteLine("south");
        Lobby CurrentRoom = new Lobby();
            CurrentRoom.look();
          break;

        default:
          directions();
          break;
      }
    }
    public void look()
    {
      System.Console.WriteLine("You see a room with several sleeping guards, The room smells of sweaty men. The bed closest to you is empty and there are several uniforms tossed about.");
      System.Console.WriteLine("[(s)outh");
      directions();
    }

    // public void useItem(List<Item> item)



  }


}





// Barracks
//     // Description:
//     // "You see a room with several sleeping guards, The room smells of sweaty men."
//     // "The bed closest to you is empty and there are several uniforms tossed about."
//     directions =  [s]
//       s = Lobby

//       Room_Actions:
//         Use Bed: //"You climb into the bed and pretend to be asleep. A few minutes later several guards walk into the
//              // room. One approaches you to wake you... (GUARD) "Hey Get Up! it's your turn for watch, Go relieve 
//              // Shigeru in the Guard Room" Quickly you climb out of the bed",
//              // @ts-ignore
//         Use Bed: * 2 //"(GUARD) What do you think your doing? Hey your not Leroy, Quick Jenkins sieze him.... 
//                  //Jenkins a bit over-zelous swings his sword cleaving you in half... ",

//         Take: GuardUniform // "You placed the Guard Uniform in your inventory" 

//       Props_Needed:
//         Bed 
//         Guard

//       Items_Needed:
//         GuardUniform
