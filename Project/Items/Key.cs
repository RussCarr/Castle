namespace CastleGrimtol.Project.Items
{
  public class Key : IItem
  {

    public string Name { get; set; } 
    public string Description { get; set; } = "A key to unlock a door.";
   
   public Key(string name)
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






