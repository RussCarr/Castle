using System.Collections.Generic;

namespace CastleGrimtol.Project
{
  public class Key : IItem
  {

    public string Name { get; set; } 
    public string Description { get; set; } = "A key to unlock a door.";
   
   public Key(string _name)
   {
       Name = _name;

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
  class GuardUniform : IItem
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
  }

  class Note : IItem
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
  }
  class Vail : IItem
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

  }
  class Hammer : IItem
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
  }
  class BrokenLock : IItem
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
  }
  class MessengerOvercoat : IItem
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
  }
  class Window : IItem
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
  }
}






