using LadderAndSnake.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LadderAndSnake.Shortcuts
{
    internal class WinShortCut : ShortCut
    {
        public WinShortCut(int start, int end) : base(start, end) { }

        internal override PlayerDataDTO Calculate(PlayerDataDTO playerData, int exitPoint)
        {
            playerData.Position = exitPoint;
            return playerData;
        }
    }
}
