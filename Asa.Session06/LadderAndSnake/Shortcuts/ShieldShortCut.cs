using LadderAndSnake.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LadderAndSnake.Shortcuts
{
    internal class ShieldShortCut : ShortCut
    {
        public ShieldShortCut(int start, int end) : base(start, end) { }

        internal override PlayerDataDTO Calculate(PlayerDataDTO playerData, int exitPoint)
        {
            if(Start > End) // it's a ladder
            {
                playerData.Position = End;
                playerData.Shields++;
            }
            else // it's a snake
            {
                if(playerData.Shields <= 0)
                {
                    playerData.Position = End;
                }
                else
                {
                    playerData.Shields--;
                }
            }
            return playerData;
        }
    }
}
