using System.Collections.Generic;

namespace CastleGrimtol.Project.Items
{
  class Hammer : IItem
  {


    public string Name { get; set; }
    public string Description { get; set; }


    public Hammer(string name)
    {
      Name = name;
    }


    public void use()
    {
      System.Console.WriteLine("You used the " + Name + "!");
    }
    public void take()
    {
      System.Console.WriteLine("You grabbed the " + Name + "!");
    }
  }


}






