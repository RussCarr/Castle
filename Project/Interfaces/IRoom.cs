using System;
using System.Collections.Generic;

namespace CastleGrimtol.Project
{
  public interface IRoom
  {
    string Name { get; set; }
    string Description { get; set; }
    
    void look();
    void directions();
  }


}

