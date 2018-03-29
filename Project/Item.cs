using System;

namespace CastleGrimtol.Project
{

  public class Item 
  {

    public string Name { get; set; }
    public string Description { get; set; }

    public Item(string name, string description)
    {
      Name = name;
      Description = description;
    }

    public Item(string v)
    {
      v = Name;
      Description = "something";
    }

    public void useItem()
    {
      System.Console.WriteLine("You used the " + this.Name + "!");
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






