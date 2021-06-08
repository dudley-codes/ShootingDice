using System;

namespace ShootingDice
{
  // TODO: Complete this class

  // A player the prompts the user to enter a number for a roll
  public class HumanPlayer : Player
  {
    public override void Play(Player other)
    {
      // Call roll for "this" object and for the "other" object
      int HumanRoll;
      Console.Write("I am a human. Please enter a human number: ");
      bool success = Int32.TryParse(Console.ReadLine(), out HumanRoll);
      int myRoll = HumanRoll;
      int otherRoll = other.Roll();

      Console.WriteLine($"{Name} rolls a {myRoll}.");
      Console.WriteLine($"{other.Name} rolls a {otherRoll}");

      if (myRoll > otherRoll)
      {
        Console.WriteLine($"{Name} Wins!");

      }
      else if (myRoll < otherRoll)
      {
        Console.WriteLine($"{other.Name} Wins!");
      }
      else
      {
        // if the rolls are equal it's a tie
        Console.WriteLine("It's a tie");
      }
    }
  }
}