using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{


  // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
  public class CreativeSmackTalkingPlayer : Player
  {
    public List<string> Taunts { get; set; }
    // void Insults()
    // {
    //   List<string> Taunts = new List<string>();
    //   Taunts.Add("Booo!");
    //   Taunts.Add("You suck!");
    //   Taunts.Add("Your mother was a hamster!");
    //   Taunts.Add("You couldn't lose more if you tried!");

    //   int maxIndex = Taunts.Count;
    //   Random random = new Random();
    //   int randomIndex = random.Next(0, maxIndex);
    // }



    public CreativeSmackTalkingPlayer()
    {
      Taunts = new List<string>();
    }
    public override int Roll()
    {
      List<string> Taunts = new List<string>();
      Taunts.Add("Booo!");
      Taunts.Add("You suck!");
      Taunts.Add("Your mother was a hamster!");
      Taunts.Add("You couldn't lose more if you tried!");

      int maxIndex = Taunts.Count;
      Random random = new Random();
      int randomIndex = random.Next(0, maxIndex);
      Console.WriteLine(Taunts[randomIndex]);
      // Return a random number between 1 and DiceSize
      return new Random().Next(DiceSize) + 1;
    }
  }
}