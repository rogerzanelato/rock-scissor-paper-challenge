using RockPaperScissor.Exceptions;
using RockPaperScissor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockPaperScissor.Game
{
    public class Rule : IRule
    {
        private readonly string[] _validMoves;
        public const int MaxPlayersNumber = 2;
        public Rule()
        {
            _validMoves = new string[3];
            _validMoves[0] = Strategy.Paper;
            _validMoves[1] = Strategy.Rock;
            _validMoves[2] = Strategy.Scissor;
        }

        public void ValidateMatch(IMatch match)
        {
            ValidatePlayersForMatch(match.Players);
            ValidatePlayersStrategy(match.Players);
        }

        protected void ValidatePlayersForMatch(IList<IPlayer> players)
        {
            if (players.Count != MaxPlayersNumber)
            {
                var ErrorMessage = string.Format("This match has a wrong number of players. Players supplied: {0:D} / Limit: {1:D}", players.Count, MaxPlayersNumber);
                throw new WrongNumberOfPlayersError(ErrorMessage);
            }
        }

        protected void ValidatePlayersStrategy(IList<IPlayer> players)
        {
            foreach (var player in players)
            {
                if (!ValidateStrategy(player.Strategy))
                {
                    var JoinedTypesValid = string.Join(", ", _validMoves);
                    var ErrorMessage = string.Format("Invalid strategy of player {0}. The strategy supplied must be one of these: {1}. Provided: {2}", player.Strategy, JoinedTypesValid, player.Strategy.Move);
                    throw new NoSuchStrategyError(ErrorMessage);
                }
            }
        }

        protected bool ValidateStrategy(IStrategy strategy)
        {
            string value = strategy.Move.ToUpper();
            return _validMoves.Contains(value);
        }
    }
}
