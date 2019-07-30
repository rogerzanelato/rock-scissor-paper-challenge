using System;

namespace RockPaperScissor.Exceptions
{
    public class WrongNumberOfPlayersError : Exception
    {
        public WrongNumberOfPlayersError(string message) : base(message)
        {
        }
    }
}
