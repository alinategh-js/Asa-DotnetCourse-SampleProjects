using LadderAndSnake.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LadderAndSnake
{
    internal abstract class ShortCut
    {
        public int Start { get; }
        public int End { get; }

        internal ShortCut(int start, int end)
        {
            Start = start;
            End = end;
        }

        public override bool Equals(object obj)
        {
            return obj is ShortCut cut &&
                   Start == cut.Start &&
                   End == cut.End;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Start, End);
        }

        internal virtual PlayerDataDTO Calculate(PlayerDataDTO playerData, int exitPoint) => playerData;
    }
}
