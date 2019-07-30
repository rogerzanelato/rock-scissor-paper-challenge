using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissor.Interfaces
{
    public interface IPlayer
    {
        IStrategy Strategy { get; set; }

        string Name { get; set; }
    }
}
