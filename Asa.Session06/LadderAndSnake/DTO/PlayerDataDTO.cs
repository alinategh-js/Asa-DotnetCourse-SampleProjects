using System;
using System.Collections.Generic;
using System.Text;

namespace LadderAndSnake.DTO
{
    public struct PlayerDataDTO
    {
        public int Position { get; set; }
        public int Shields { get; set; }
        public int DiceValue { get; set; }
    }
}
