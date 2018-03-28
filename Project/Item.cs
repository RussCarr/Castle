using System.Collections.Generic;

namespace CastleGrimtol.Project
{

  class Item : IItem
  {

    public string Name { get; set; }
    public string Description { get; set; }
    
     public void use()
    {
      System.Console.WriteLine("You used the " + Name + "!");
    }
    public void take()
    {
      System.Console.WriteLine("You grabbed the " + Name + "!");
    }
      // var items = new List<Project.IItem>();

    //  public void Key (); 
    //   Key Key = new Key("Silver Key");
    // //   new Hammer()

        // System.Console.WriteLine();
        // silverKey.use ();
        // System.Console.ReadLine();
  }


}






