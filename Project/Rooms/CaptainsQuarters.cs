// CaptainsQuarters
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
      