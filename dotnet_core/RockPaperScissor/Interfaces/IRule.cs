using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissor.Interfaces
{
    public interface IRule
    {
        void ValidateMatch(IMatch match);
    }
}
