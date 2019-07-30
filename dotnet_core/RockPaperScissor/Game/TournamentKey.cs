using RockPaperScissor.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissor.Game
{
    public class TournamentKey : ITournamentKey
    {
        public IList<IMatch> Matches { get; set; }

        public IPlayer CalculateTournamentKeyWinner()
        {
            return CalculateWinnerFromMatches(Matches, 1);
        }

        private IPlayer CalculateWinnerFromMatches(IList<IMatch> _matches, int loopIndice)
        {
            if (_matches.Count == 1)
            {
                Console.WriteLine("Starting Final Match of this Brace!");
                // If it's the final match, we end the recursive Loop with the Winner
                return _matches[0].CalculateMatchWinner();
            }

            var newMatch = new Match();
            var newPlayers = new List<IPlayer>();

            Console.WriteLine("Starting Match {0}", loopIndice);
            var winner1 = (Player) _matches[0].CalculateMatchWinner();

            loopIndice += 1;
            Console.WriteLine("Starting Match {0}", loopIndice);
            var winner2 = (Player) _matches[1].CalculateMatchWinner();

            // The near neighboor's will be matched against one another
            newPlayers.Add(winner1);
            newPlayers.Add(winner2);

            // The matches use the same rules
            newMatch.Rule = _matches[0].Rule;
            newMatch.Players = newPlayers;

            // Excluding the matches already done
            _matches.RemoveAt(0);
            _matches.RemoveAt(0);

            // Adding to the final of the list, the match with the Winners
            _matches.Add(newMatch);

            loopIndice += 1;
            return CalculateWinnerFromMatches(_matches, loopIndice);
        }
    }
}
