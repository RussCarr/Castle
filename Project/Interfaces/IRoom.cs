
using System;

namespace CastleGrimtol.Project
{
  public interface IRoom 
  {
    string Name { get; set; }
    string Description { get; set; }
    // List<Item> Items { get; set; }

    void useItem();
   void look();
 
  }

}