using RockPaperScissor.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissor.Game
{
    public class Strategy : IStrategy
    {
        public const string Rock = "R";
        public const string Paper = "P";
        public const string Scissor = "S";

        public string Move { get; set; }
    }
}
