using System;

namespace CastleGrimtol.Project
{

  class Item 
  {

    public string Name { get; set; }
    public string Description { get; set; }

    public Item(string name, string description)
    {
      Name = name;
      Description = description;
    }

       public void useItem()
    {
      System.Console.WriteLine("You used the " + Name + "!");
    }
    public void takeItem()
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






