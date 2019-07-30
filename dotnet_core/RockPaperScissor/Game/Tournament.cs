using RockPaperScissor.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissor.Game
{
    public class Tournament : ITournament
    {
        public IList<ITournamentKey> TournamentKeys { get; set; }

        public IPlayer CalculateTournamentWinner()
        {
            Console.WriteLine("Starting the tournament..");
            Console.WriteLine("");

            List<Player> finalWinners = new List<Player>();

            int loopIndex = 0;
            foreach (var brace in TournamentKeys)
            {
                loopIndex += 1;
                Console.WriteLine("Starting Brace {0}", loopIndex);

                Player winner = (Player) brace.CalculateTournamentKeyWinner();
                finalWinners.Add(winner);

                Console.WriteLine("Brace {0} ended with {1} as Champion!", loopIndex, winner.Name);
                Console.WriteLine("");
            }


            Console.WriteLine("Starting the last brace!");
            TournamentKey lastBrace = OrganizeWinnersInANewBrace(finalWinners);

            Player finalWinner = (Player) lastBrace.CalculateTournamentKeyWinner();

            Console.WriteLine("");
            Console.WriteLine("Player {0} is the final champion!!!", finalWinner.Name);

            return finalWinner;
        }

        TournamentKey OrganizeWinnersInANewBrace(List<Player> winners)
        {
            TournamentKey lastBrace = new TournamentKey();

            var matches = new List<IMatch>();

            IList<IPlayer> tmpMatchPlayers = new List<IPlayer>();
            var loopIndice = 0;

            foreach (var winner in winners)
            {
                loopIndice += 1;

                tmpMatchPlayers.Add(winner);

                // If we already have the players necessary for the match
                if (loopIndice - Rule.MaxPlayersNumber == 0)
                {
                    var match = new Match();
                    match.Players = tmpMatchPlayers;
                    match.Rule = new Rule();

                    matches.Add(match);

                    // reset
                    loopIndice = 0;
                    tmpMatchPlayers = new List<IPlayer>();
                }
            }

            lastBrace.Matches = matches;

            return lastBrace;
        }
    }
}
