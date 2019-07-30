using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissor.Interfaces
{
    public interface ITournamentKey
    {
        IList<IMatch> Matches { set; get; }

        IPlayer CalculateTournamentKeyWinner();
    }
}
