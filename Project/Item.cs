using System.Collections.Generic;

namespace CastleGrimtol.Project
{

  class items : IItem
  {

    public string Name { get; set; }
    public string Description { get; set; }
    public items(string _name)
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


}






