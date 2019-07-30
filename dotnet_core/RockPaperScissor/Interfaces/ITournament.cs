using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissor.Interfaces
{
    public interface ITournament
    {
        IList<ITournamentKey> TournamentKeys { set; get; }

        IPlayer CalculateTournamentWinner();
    }
}
