using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public interface IGame
    {
        Room CurrentRoom { get; set; }
        Player CurrentPlayer { get; set; }

        void Setup();
        void Reset();

        //No need to Pass a room since Items can only be used in the CurrentRoom
        void UseItem(string itemName);

    }

help()

quit()

switch (choise)
{
    case: n || north
    break;
    case: e || east
    break;
    case: s || south
    break;
    case: w || west
    break;
    case: q || quit
    break;
    case: h || help
    break;
    case: i || inventory
    break;
    case: u || use
    break;
    case: t || take
    
    
    default:
    break;
}


}
