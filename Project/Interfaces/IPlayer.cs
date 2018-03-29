using System.Collections.Generic;
using CastleGrimtol.Project;
namespace CastleGrimtol.Project
{
  public interface IPlayer
  {
    int Pscore { get; set; }
    List<Item> Inventory { get; set; }
    
    void score();
    void inventory();
  }
}