using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissor.Interfaces
{
    public interface IMatch
    {
        IList<IPlayer> Players { set; get; }

        IRule Rule { set; get; }

        IPlayer CalculateMatchWinner();
    }
}
