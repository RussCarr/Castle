using System.Collections.Generic;

namespace CastleGrimtol.Project.Rooms
{
  public class Room : IRoom
  {
    public string Name { get; set; }
    public string Description { get; set; }
    
    List<Item> Items { get; set; }
    

    public Room(string name, string description)
    {
      Name = name;
      Description = description;
      // Item = new List<Item>();
    }
    public void story()
    {

    }
    public void directions()
    {

    }
    public void look()
    {
      System.Console.WriteLine("You have found your way into the castle through a secret tunnel but you can't turn back. The tunnel collapsed and now you will need to find a way to disguise yourself and kill the Dark Lord. We don't know exactly how so you'll need to use your wit and cunning to think of something.");
    }

    public void useItem(List<Item> item)
    {
      Items = item;
    }

    public void useItem()
    {
      throw new System.NotImplementedException();
    }
  }
}


// take <item> "will pick up and put into inventory"
// use <item> "will use item"
// look = "Displays the Description of the current room"
// inventory = "This command will list of the current items in your inventory"

// Rooms
// There are several key rooms in this story. Entering a room will trigger an event. If you enter a room without the proper disguise chances are you will be killed. You will need to navigate throughout the castle avoiding dangerous locations and pick up the items necessary to complete the game. A basic breakdown of the rooms.

// Hallway()

// //Description: 
// Console.WriteLine("You find yourself in a small hall there doesnt appear to be anything of interest here. You see a passage to the ['North', 'South ? UseKey : "Locked"']",)

// Barracks()

// //Description:
// Console.WriteLine("You see a room with several sleeping guards, The room smells of sweaty men. The bed closest to you is empty and there are several uniforms tossed about.")

// Actions: {

// use bed: "You climb into the bed and pretend to be asleep. A few minutes later several guards walk into the room. One approaches you to wake you... (GUARD) "Hey Get Up! it's your turn for watch, Go relieve Shigeru in the Guard Room" Quickly you climb out of the bed",

// use bed * 2: "(GUARD) What do you think your doing? Hey your not Leroy, Quick Jenkins sieze him.... Jenkins a bit over-zelous swings his sword cleaving you in half... ",

// take uniform: "You placed the Guard Uniform in your inventory" },

// Items: ['Guard Uniform'],

// Exits: ['South']

// CastleCourtyard()

// //Description:
// Console.WriteLine("You step into the large castle courtyard there is a flowing fountain in the middle of the grounds and a few guards patrolling the area.")

// Events

// -"Oi, long night tonight I wish I was in my bed. If your just getting on shift your should go talk to the captain."
// "To your left you see a guard approaching you. (GUARD) Wat who the blazes are you? Quickly he raises the alarm and several of the crossbow men turn and fire on you. You realize you have made a grave mistake as a bolt slams into your body... ">"
// Actions: {

// use key: "You approach the door and slide the key into the lock. It clicks, The door can now be opened",
// },

// Items: [],

// Exits: ['South', 'West', 'North']

// CaptainsQuarters()

// //Description:
// Console.WriteLine("As you approach the captains Quarters you swallow hard and notice your lips are dry, Stepping into the room you see a few small tables and maps of the countryside sprawled out.")

// Events

// <CAPTAIN_IN_ROOM && INVENTORYCHECK !broken lock>
// The captain on shift greets you (CAPTAIN) New recruit huh. Well lets stick you in the guard room you can't screw things up there. Go relieve (He pauses and glancing at his reports) private Miyamoto.
// <CAPTAIN_IN_ROOM && INVENTORYCHECK broken lock>
// "What are you doing back here? I told you to stay in the Guard Room"
// "With the captain gone you look around and notice a pouch of vials hung from the back of the chair the captain was sitting at. The vials are holding a green liquid.">",
// Actions: {

// use brocke lock: "What an escaped prisoner... When did this happen? Quick take this (He slams a silver key on the table and jots down a quick note) go fetch a messenger boy for me and have him take this note the Gate Captain Ezio, but keep this quite. If That prisoner is really has escaped it will be both our heads. (CAPTAIN) I'll go rouse the guards, (The captain runs to the door north heading for the Barracks)",

// take key: "Quickly you pocket the silver key" },

// Items: ["key", "note", "vial"],

// Exits: ['north', 'east']

// GuardRoom()

// //Description:
// Console.WriteLine( "Pushing open the door of the guard room you look around and notice the room is empty, There are a few small tools in the corner and a chair propped against the wall near the that likely leads to the dungeon.")
// Actions: {
// take tools: "Rifling through the tools you see a hammer... It looks useful. You put it in your inventory", },
// Items: ["hammer"],
// Exits: ['north', 'west']

// Dungeon()

// //Description: 
// Console.WriteLine("As you descend the stairs to the dungeon you notice a harsh chill to the air. Landing a the base of the stairs you see what the remains of a previous prisoner.")
// Events
// <PRISONER_CHAINED>
// You also notice a man sitting in shackles. As you approach him you notice a small lock binding him to the wall with chains. As you near the prisoner his face turns to a deep frown.... (PRISONER) You look familiar, Hey thats right I know you from the village. Have you seriously turned your back on us and joined this squad of goons, He sighs defeated...
// "Your plan is great but how will I get out of here?">"
// <PRISONER_FREE>
// "There doesn't appear to be anything else of interest here." :
// Actions: {
// use hammer: "Quickly you explain your plan to the man and a new light of hope dances across his face. (PRISONER) This is wonderful news but how am I going to get out of here?",

// take broken lock: "You pick up the broken lock. Hey it might be useful",

// use messenger overcoat: "You hand of the clothes and the old man puts them on. With this disguise I'll be able to walk out of this place tomorrow. Thank you.", },

// Items: ["broken lock"],
// Exits: ['north', 'west']

// SquireTower()

// //Description:
// Console.WriteLine("As you finish climbing the stairs to the squire tower you see a messenger nestled in his bed. His messenger overcoat is hanging from his bed post. ")

// Actions: {

// take messenger overcoat: "You discretely fold up the overcoat and hide it inside your armor",

// use note: "You wake the messenger and hand him the note along with his orders.

// Events

// - "Shouting at the messenger you kick his bed and demand he take your note to the gate captain. The messenger quickly shakes off his sleep runs from the room with your note"
// <INVENTORYCHECK !overcoat>
// "Slowly the messenger gets up and asks (MESSENGER) What..., Who? You repeat the captains orders. Grumbling to himself about the middle of the night the messenger dawns his overcoat snatches the note from your hands and walks out of the room, still complaining about being woken in the middle of the night." },
// Items: ["messenger overcoat"],

// Exits: ['North', 'West']


// WarRoom()
// //Description: 
// Console.WriteLine("Steping into the war room you see several maps spread across tables. On the maps many of the villages have been marked for purification. You also notice several dishes of prepared food to the side perhaps the war council will be meeting soon.")
// Actions: {
// use Vial: "As you are staring around the room you realize the vial is likely the deadly poisen that the guards have been putting on their arrowheads. Looking for the most ornate cups you drain the vial into the cup then toss the vial out the window.", },
// Items: ["Window"],
// Exits: ['South']

// ThroneRoom()
// //Description:
// Console.WriteLine("As you unlock the door and swing it wide you see an enormous hall stretching out before you. At the opposite end of the hall sitting on his throne you see the dark lord. The Dark Lord shouts at you demanding why you dared to interrupt him during his Ritual of Evil Summoning... Dumbfounded you mutter an incoherent response. Becoming more enraged the Dark Lord complains that you just ruined his concentration and he will now have to start the ritual over... Quickly striding towards you he smirks at least I know have a sacrificial volunteer. Plunging his jewel encrusted dagger into your heart your world slowly fades away. ")


// Victory Conditions
// //DEATH MESSAGE: 
// Console.WriteLine("You have died, the rebellion has failed.")
// //Dark Lord Assasinated:
// Console.WriteLine("You succeeded where so many others failed. The Dark Lords' reign of terror is over.")
// //Dark Lord Assasinated and Prisoner Freed: 
// Console.WriteLine("You are a true hero! The Dark Lords' reign of terror is over and you freed a old man not bad for a single night of work.")


// //go <direction>

// //Directions: 
// north();
// south();
// east();
// west();
// Cheaters Guide



// Go North
// Use Bed // For Points Only
// Take Uniform
// Use Uniform
// Go South
// Go West
// Go South
// Go West
// Take Tools
// Go North
// Use Hammer
// Take Lock
// Go South
// Go West
// Go West
// Use Lock
// Take Vial
// Go East
// Go North
// Go North
// Go East
// Take Overcoat
// Use Note
// Go North
// Take Key
// Go South
// Go West
// Go South
// Go South
// Go East
// Go North
// Use Overcoat
// Go South
// Go West
// Go North
// Go North
// Use Key // For Points Only
// Go East
// Go North
// Use Window