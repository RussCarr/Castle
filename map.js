
// //Rooms
// var Lobby = "Lobby"
// var Barracks = "Barracks"
// var ThroneRoom = "Throne Room"
// var CaptainsQuarters = "CaptainsQuarters"
// var CastleCourtyard = "CastleCourtyard"
// var Dungenon = "Dungenon"
// var GuardRoom="GuardRoom"
// var CouncilRoom = "CouncilRoom"
// var SquireTower = "SquireTower"
// var SouthHallway = "SouthHallway"
// var NorthHallway = "NorthHallway"

// //Directions
// var directions = []
// var e = "east"
// var w = "west"
// var n = "north"
// var s = "south"

// //Helpers
// var Room_Action = "Room Action"
// var Room_Events = "Room Events"
// var Props_Needed= "Props Needed"
// var Room_Requires = "Room Requires"

// var Items_Needed = "Items Needed"

// var Start = "Start"
// var Exit = "Exit"

// var Inventory = "Inventory" + "This command will list of the current items in your inventory"
// var Help = "Help" + "This will pull up a Help Commands"
// var Quit = "Quit" + "This will quit the game"
// var Take = "Take '<required item>'" + "This will pick up and put into inventory"
// var Use = "Use '<required item>'" + "This will use item"
// var Look = "look" + "Displays the Description of the current room"

// //Items
// var Key = "Key"
// var GuardUniform = "Guard Uniform"
// var Vail = "Vail"
// var Hammer = "Hammer"
// var Note = "Note"
// var BrokenLock = "Broken Lock"
// var MessengerOvercoat = "Messenger Overcoat"

// //Props
// var SmallWindow = "Small Window"
// var Bed = "Bed"
// var Captain = "Captain"
// var Guard = "Guard"
// var Prisioner = "Prisioner"

// //Actions
// var Use = "Use"
// var Take = "Take"

// //Map

// Start
// //Brave Young Warrior our forces are failing and the enemy grows stronger everyday. 
// //I fear if we don't act now our people will be driven from their homes. These dark times 
// //have left us with one final course of action. We must cut the head off of the snake by 
// //assasinating the Dark Lord of Grimtol... Our sources have identified a small tunnel that 
// //leads into the rear of the castle.




//   Lobby 
//     // Description:
//     // "You have found your way into the castle through a secret tunnel but you can't turn back. 
//     //The tunnel collapsed and now you will need to find a way to disguise yourself 
//     //and kill the Dark Lord. We don't know exactly how so you'll need to use your wit and 
//     //cunning to think of something.
    
//     directions =  [n, e, s, w]
//       n = Barracks
//       e = CastleCourtyard
//       s = CaptainsQuarters
//       w = Exit

//   Barracks
//     // Description:
//     // "You see a room with several sleeping guards, The room smells of sweaty men."
//     // "The bed closest to you is empty and there are several uniforms tossed about."
//     directions =  [s]
//       s = Lobby
      
//       Room_Actions:
//         Use Bed: //"You climb into the bed and pretend to be asleep. A few minutes later several guards walk into the
//              // room. One approaches you to wake you... (GUARD) "Hey Get Up! it's your turn for watch, Go relieve 
//              // Shigeru in the Guard Room" Quickly you climb out of the bed",
//              // @ts-ignore
//         Use Bed: * 2 //"(GUARD) What do you think your doing? Hey your not Leroy, Quick Jenkins sieze him.... 
//                  //Jenkins a bit over-zelous swings his sword cleaving you in half... ",
                
//         Take: GuardUniform // "You placed the Guard Uniform in your inventory" 
      
//       Props_Needed:
//         Bed 
//         Guard

//       Items_Needed:
//         GuardUniform
        


//   CaptainsQuarters
//     //Description:
//     //"As you approach the captains Quarters you swallow hard and notice your lips are dry, 
//     //Stepping into the room you see a few small tables and maps of the countryside sprawled out.")
    
//     directions =  [n, e]
//       n = Lobby
//       e = SouthHallway

//     Room_Events
      
//       //<CAPTAIN_IN_ROOM && INVENTORYCHECK !broken lock>
//       //The captain on shift greets you (CAPTAIN) New recruit huh. Well lets stick you in the guard room you 
//       //can't screw things up there. Go relieve (He pauses and glancing at his reports) private Miyamoto.
      
//       //<CAPTAIN_IN_ROOM && INVENTORYCHECK broken lock>
//       //"What are you doing back here? I told you to stay in the Guard Room"
      
//       //<!CAPTAIN_IN_ROOM && INVENTORYCHECK broken lock>
//       //"With the captain gone you look around and notice a pouch of vials hung from the back of the chair 
//       //the captain was sitting at. The vials are holding a green liquid.">",
      
//       Actions: {
      
//       Use BrokenLock: //"What an escaped prisoner... When did this happen? Quick take this (He slams a silver key 
//                       //on the table and jots down a quick note) go fetch a messenger boy for me and have him take 
//                       //this note the Gate Captain Ezio, but keep this quite. If That prisoner is really has escaped 
//                       //it will be both our heads. (CAPTAIN) I'll go rouse the guards, (The captain runs to the door
//                       //north heading for the Barracks)",
      
//       Take Key: "Quickly you pocket the silver key"
      
//       Props_Needed:
//         Captain
      
//       Items_Needed:
//           Note
//           Vail
//           Key
      
//       Required_Items: 
//         BrokenLock
      

  
//   CastleCourtyard
//     //Description:
//     //You step into the large castle courtyard there is a flowing fountain in the middle of the grounds and a 
//     //few guards patrolling the area.
    
//     directions =  [n, s, w]
//       n = NorthHallway
//       s = SouthHallway
//       w = Lobby

//       Events:
//         //"Oi, long night tonight I wish I was in my bed. If your just getting on shift your should go talk 
//         //to the captain."
      
//         //"To your left you see a guard approaching you. (GUARD) Wat who the blazes are you? Quickly he 
//         //raises the alarm and several of the crossbow men turn and fire on you. You realize you have made a 
//         //grave mistake as a bolt slams into your body... ">"
      
//       Props_Needed:
//         Guard

//       Room_Actions:
//         Key: //"You approach the door and slide the key into the lock. It clicks, The door can now be opened"
   
//   ThroneRoom
//     //Description:
//     //"As you unlock the door and swing it wide you see an enormous hall stretching out before you. 
//     //At the opposite end of the hall sitting on his throne you see the dark lord. The Dark Lord shouts at you 
//     //demanding why you dared to interrupt him during his Ritual of Evil Summoning... Dumbfounded you mutter an 
//     //incoherent response. Becoming more enraged the Dark Lord complains that you just ruined his concentration 
//     //and he will now have to start the ritual over... Quickly striding towards you he smirks at least I know have 
//     //a sacrificial volunteer. Plunging his jewel encrusted dagger into your heart your world slowly fades away.
  
//   directions =  [s]
//       s = NorthHallway

//   Dungenon
//     //Description: 
//     //"As you descend the stairs to the dungeon you notice a harsh chill to the air. Landing a the base of 
//     //the stairs you see what the remains of a previous prisoner.
  
//     Events
//       //<PRISONER_CHAINED>
//       //You also notice a man sitting in shackles. As you approach him you notice a small lock binding him 
//       //to the wall with chains. As you near the prisoner, his face turns to a deep frown.... (PRISONER) You 
//       //look familiar... Hey thats right I know you from the village. Have you seriously turned your back on us 
//       //and joined this squad of goons, He sighs defeated...
  
//       //<PRISONER_FREE>
//       //"Your plan is great but how will I get out of here?">"
      
//       //"There doesn't appear to be anything else of interest here."
  
//       Actions: {
//         Use Hammer: //"Quickly you explain your plan to the man and a new light of hope dances across his face. 
//                     //(PRISONER) This is wonderful news but how am I going to get out of here?",
  
//         Take BrokenLock: //"You pick up the broken lock. Hey it might be useful",
  
//         Use MessengerOvercoat: //"You hand off the clothes and the old man puts them on. You see with this disguise 
//                                //you will be able to walk out of this place tomorrow. (PRISONER) Thank you."
  
//       Props_Needed:
//         Prisioner
      
//       Items_Needed:
//         BrokenLock
//         Hammer  
//         MessengerOvercoat
  
//     directions =  [s]
//       s = GuardRoom

//   GuardRoom
//     //Description:
//     //Pushing open the door of the guard room you look around and notice the room is empty, There are a few 
//     //small tools in the corner and a chair propped against the wall near the that likely leads to the dungeon.
      
      
//       Actions: {
//       Take Hammer: //"Rifling through the tools you see a hammer... It looks useful. You put it in your inventory"
      
      
//       Items_Needed:
//           Hammer
         
//       directions =  [n, w]
//       n = Dungenon
//       e = SouthHallway

//   CouncilRoom
//     //Description: 
//     //"Steping into the war room you see several maps spread across tables. On the maps many of the villages 
//     //have been marked for purification. You also notice several dishes of prepared food to the side perhaps the 
//     //war council will be meeting soon.")
  
//       Room_Actions: 
//         Vial: //"As you are staring around the room you realize the vial is likely the deadly poisen that 
//               //the guards have been putting on their arrowheads. Looking for the most ornate cups you drain
//               //the vial into the cup then toss the vial out the window."
  
//     Props_Needed: 
//         SmallWindow
    
//       Items_Needed:
//         Vial

//   directions =  [s]
//       s = SquireTower

//   SquireTower
//     //Description:
//     //"As you finish climbing the stairs to the squire tower you see a messenger nestled in his bed. His 
//     //messenger overcoat is hanging from his bed post.
      
//       Room_Actions:
//       Take MessengerOvercoat: //"You discretely fold up the overcoat and hide it inside your armor"
      
//       Use Note: //"You wake the messenger and hand him the note along with his orders.
      
//       Events:
//         //"Shouting at the messenger you kick his bed and demand he take your note to the gate captain. 
//         //The messenger quickly shakes off his sleep runs from the room with your note"
      
//         //<INVENTORYCHECK !overcoat>
//         //"Slowly the messenger gets up and asks (MESSENGER) What..., Who? You repeat the captains orders. 
//         //Grumbling to himself about the middle of the night the messenger dawns his overcoat snatches the note 
//         //from your hands and walks out of the room, still complaining about being woken in the middle of the night."
      
//       Room_Requires:
//         MessengerOvercoat
      
//       Items_Needed: 
//         MessengerOvercoat

//     directions =  [n, w]
//       n = CouncilRoom
//       w = NorthHallway

//   SouthHallway 
//     // Description:
//     // "You find yourself in a small hall there doesnt appear to be anything of interest here."
//     // "You see a passage to the [(n)orth , (e)ast , (w)est]"
//     directions =  [n, e, w]
//       n = CastleCourtyard
//       e = GuardRoom
//       w = CaptainsQuarters

//     Room_Requires [Key, "Door locked to the West"]

//   NorthHallway 
//     // Description:
//     // "You find yourself in a small hall there doesnt appear to be anything of interest here."
//     // "You see a passage to the [(n)orth , (e)ast , (s)outh]"
//     directions =  [n, e, s]
//       n = ThroneRoom
//       e = SquireTower
//       s = CastleCourtyard

//     Room_Requires [Key,"Door locked to the North"] 

// //Victory Conditions
//   //DEATH MESSAGE: 
//       //"You have died, the rebellion has failed."
//   //Dark Lord Assasinated:
//       //"You succeeded where so many others failed. The Dark Lords' reign of terror is over.
//   //Dark Lord Assasinated and Prisoner Freed: 
//       //"You are a true hero! The Dark Lords' reign of terror is over and you freed a old man not bad 
//       //for a single night of work.
      









// //   Go North
// // Use Bed // For Points Only
// // Take Uniform
// // Use Uniform
// // Go South
// // Go West
// // Go South
// // Go West
// // Take Tools
// // Go North
// // Use Hammer
// // Take Lock
// // Go South
// // Go West
// // Go West
// // Use Lock
// // Take Vial
// // Go East
// // Go North
// // Go North
// // Go East
// // Take Overcoat
// // Use Note
// // Go North
// // Take Key
// // Go South
// // Go West
// // Go South
// // Go South
// // Go East
// // Go North
// // Use Overcoat
// // Go South
// // Go West
// // Go North
// // Go North
// // Use Key // For Points Only
// // Go East
// // Go North
// // Use Window