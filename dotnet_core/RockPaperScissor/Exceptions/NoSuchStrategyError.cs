using System;

namespace RockPaperScissor.Exceptions
{
    public class NoSuchStrategyError : Exception
    {
        public NoSuchStrategyError(string message) : base(message)
        {
        }
    }
}
