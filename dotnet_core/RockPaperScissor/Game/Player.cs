using RockPaperScissor.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissor.Game
{
    public class Player : IPlayer
    {
        public IStrategy Strategy { get; set; }
        public string Name { get; set; }
    }
}
