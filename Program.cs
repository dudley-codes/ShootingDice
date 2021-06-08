using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
  class Program
  {
    static void Main(string[] args)
    {
      Player player1 = new Player();
      player1.Name = "Bob";

      Player player2 = new Player();
      player2.Name = "Sue";

      player2.Play(player1);

      Console.WriteLine("-------------------");

      Player player3 = new Player();
      player3.Name = "Wilma";

      player3.Play(player2);

      Console.WriteLine("-------------------");

      Player large = new LargeDicePlayer();
      large.Name = "Bigun Rollsalot";

      player1.Play(large);

      Console.WriteLine("-------------------");

      SmackTalkingPlayer smackTalker = new SmackTalkingPlayer();
      smackTalker.Name = "Karen";

      OneHigherPlayer alwaysHigher = new OneHigherPlayer();
      alwaysHigher.Name = "Snoop";

      alwaysHigher.Play(smackTalker);

      Console.WriteLine("-------------------");

      smackTalker.Play(alwaysHigher);

      Console.WriteLine("-------------------");
      HumanPlayer human = new HumanPlayer();
      human.Name = "Mr Notarobot";

      human.Play(alwaysHigher);

      Console.WriteLine("-------------------");
      CreativeSmackTalkingPlayer creative = new CreativeSmackTalkingPlayer();
      creative.Name = "Smack Talker2";

      creative.Play(large);

      Console.WriteLine("-------------------");

      SoreLoserPlayer donald = new SoreLoserPlayer();
      donald.Name = "Donald";

      donald.Play(player1);
      Console.WriteLine("-------------------");

      UpperHalfPlayer upper = new UpperHalfPlayer();
      upper.Name = "Upper Duder";

      upper.Play(player1);

      Console.WriteLine("-------------------");
      SoreLoserUpperHalfPlayer donJr = new SoreLoserUpperHalfPlayer();
      donJr.Name = "Donald, Jr";
      donJr.Play(donald);

      Console.WriteLine("-------------------");
      List<Player> players = new List<Player>() {
                player1, player2, player3, large, smackTalker, alwaysHigher, human
            };

      PlayMany(players);
    }

    static void PlayMany(List<Player> players)
    {
      Console.WriteLine();
      Console.WriteLine("Let's play a bunch of times, shall we?");

      // We "order" the players by a random number
      // This has the effect of shuffling them randomly
      Random randomNumberGenerator = new Random();
      List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

      // We are going to match players against each other
      // This means we need an even number of players
      int maxIndex = shuffledPlayers.Count;
      if (maxIndex % 2 != 0)
      {
        maxIndex = maxIndex - 1;
      }

      // Loop over the players 2 at a time
      for (int i = 0; i < maxIndex; i += 2)
      {
        Console.WriteLine("-------------------");

        // Make adjacent players play one another
        Player player1 = shuffledPlayers[i];
        Player player2 = shuffledPlayers[i + 1];

        switch (player2.ToString())
        {
          case "ShootingDice.OneHigherPlayer":
            player2.Play(player1);
            break;
          case "ShootingDice.HumanPlayer":
            player2.Play(player1);
            break;
          default:
            player1.Play(player2);
            break;
        }
      }
    }
  }
}