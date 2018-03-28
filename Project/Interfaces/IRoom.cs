using System.Collections.Generic;

namespace CastleGrimtol.Project
{
  public interface IRoom 
  {
    string Name { get; set; }
    string Description { get; set; }
    List<IItem> Items { get; set; }

    void UseItem(IItem item);
    void look();



  }

}