using RockPaperScissor.Exceptions;
using RockPaperScissor.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissor.Game
{
    public class Match : IMatch
    {
        /// <summary>
        /// This dictionary will receive a Strategy as Key and another Strategy as Pair. The Key is the strategy WINNER in a supposed
        /// duel between strategy(key) vs strategy(pair)
        /// </summary>
        private readonly Dictionary<string, string>_strategyToWinKeyAgainstPair;
        public Match()
        {
            _strategyToWinKeyAgainstPair = new Dictionary<string, string>();
            _strategyToWinKeyAgainstPair.Add(Strategy.Paper, Strategy.Rock);
            _strategyToWinKeyAgainstPair.Add(Strategy.Rock, Strategy.Scissor);
            _strategyToWinKeyAgainstPair.Add(Strategy.Scissor, Strategy.Paper);
        }
        public IList<IPlayer> Players { set; get; }
        public IRule Rule { set; get; }

        public IPlayer CalculateMatchWinner()
        {
            Rule.ValidateMatch(this);

            IPlayer PlayerA = Players[0];
            IPlayer PlayerB = Players[1];

            if (PlayerA.Strategy.Move == PlayerB.Strategy.Move)
            {
                Console.WriteLine("The players used the same strategy. Victory to the first Player: {0}", PlayerA.Name);
                return PlayerA;
            }

            string valueNecessaryToWin = "";
            if (!_strategyToWinKeyAgainstPair.TryGetValue(PlayerA.Strategy.Move, out valueNecessaryToWin))
            {
                throw new Exception(string.Format("Strategy supplied ({0}) isn't configured", PlayerA.Strategy.Move));
            }

            IPlayer Winner = valueNecessaryToWin == PlayerB.Strategy.Move
                ? PlayerA
                : PlayerB;

            Console.WriteLine("{0} ({1}) vs {2} ({3}): {4} Wins", PlayerA.Name, PlayerA.Strategy.Move, PlayerB.Name, PlayerB.Strategy.Move, Winner.Name);

            return Winner;
        }
    }
}
