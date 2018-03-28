
//Rooms
var Lobby = "Lobby"
var Barracks = "Barracks"
var ThroneRoom = "Throne Room"
var CaptainsQuarters = "CaptainsQuarters"
var CastleCourtyard = "CastleCourtyard"
var Dungenon = "Dungenon"
var GuardRoom="GuardRoom"
var CouncilRoom = "CouncilRoom"
var SquireTower = "SquireTower"
var SouthHallway = "SouthHallway"
var NorthHallway = "NorthHallway"

//Directions
var directions = []
var e = "east"
var w = "west"
var n = "north"
var s = "south"
//Helpers
var Start = "Start"
var exit = "Exit"
var i = "Inventory"
var h = "help"
var q = "quit"
//Map

Start 
  Lobby 
    directions =  [n, e, s, w]
      n = Barracks
      e = CastleCourtyard
      s = CaptainsQuarters
      w = exit

  Barracks
    directions =  [s]
      s = Lobby

  CaptainsQuarters
    directions =  [n, e]
      n = Lobby
      e = SouthHallway
  
  CastleCourtyard
    directions =  [n, s, w]
      n = NorthHallway
      s = SouthHallway
      w = Lobby

  ThroneRoom
    directions =  [s]
      s = NorthHallway

  Dungenon
    directions =  [s]
      s = GuardRoom

  GuardRoom
    directions =  [n, e]
      n = Dungenon
      e = SouthHallway

  CouncilRoom
    directions =  [s]
      s = SquireTower

  SquireTower
    directions =  [n, e]
      n = CouncilRoom
      e = NorthHallway

  SouthHallway
    directions =  [n, e, w]
      n = CastleCourtyard
      e = GuardRoom
      w = CaptainsQuarters

  NorthHallway
    directions =  [n, e]
      n = ThroneRoom
      e = SquireTower


  Go North
Use Bed // For Points Only
Take Uniform
Use Uniform
Go South
Go West
Go South
Go West
Take Tools
Go North
Use Hammer
Take Lock
Go South
Go West
Go West
Use Lock
Take Vial
Go East
Go North
Go North
Go East
Take Overcoat
Use Note
Go North
Take Key
Go South
Go West
Go South
Go South
Go East
Go North
Use Overcoat
Go South
Go West
Go North
Go North
Use Key // For Points Only
Go East
Go North
Use Window