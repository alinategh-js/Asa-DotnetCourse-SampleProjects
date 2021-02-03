using LadderAndSnake.DTO;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
[assembly: InternalsVisibleTo("LadderAndSnake.NUnitTests")]
namespace LadderAndSnake
{
    internal class Board
    {
        public int Height { get; }              
        public int Width { get; }               
        public int ExitPoint => Height * Width;

        int _ladderCount = 0;
        int _snakeCount = 0;        

        List<ShortCut> _shortCuts;// this data structure is not performant in term of time and space complexity
        public Board(BoardDataDto boardData)
        {
            Height = boardData.Height;
            Width = boardData.Width;
            _shortCuts = new List<ShortCut>();
        }

        internal void AddLadderToBoard(ShortCut ladder)
        {
            _shortCuts.Add(ladder);
            _ladderCount++;
            ValidateBoard();
            ValidateShortCuts();
        }

        internal void AddSnakeToBoard(ShortCut snakes)
        {
            _shortCuts.Add(snakes);
            _snakeCount++;
            ValidateBoard();
            ValidateShortCuts();
        }

        private void ValidateBoard()
        {
            if (Height * Width <= (_ladderCount + _snakeCount) * 2)
            {
                throw new Exception("The size of the board and number of the ladders and snakes are not compatible.");
            }
        }

        private void ValidateShortCuts()
        {
            int count = 0;
            for(int i = 1; i < ExitPoint; i++)
            {
                foreach(ShortCut s in _shortCuts)
                {
                    if (s.Start == i) count++;
                }
                if (count > 1)
                {
                    throw new Exception("Error: Overlapping snakes and ladders detected.");
                }
                count = 0;
            }
        }
        
        internal PlayerDataDTO CalculateNextPostion(PlayerDataDTO playerData)
        {
            var newPosition = playerData.Position;
            // First calculate newPosition = position + diceValue
            // First of all if newPosition exceeds the cells of the board then player cannot move.
            if (newPosition + playerData.DiceValue <= ExitPoint)
            {
                newPosition = playerData.Position + playerData.DiceValue;
            }
            playerData.Position = newPosition;
            // if player ends up on a shortcut they should move to the end of the shortcut so newPosition is calculated again.
            var newPlayerData = CheckShortCut(playerData);
            //return newPosition;
            return newPlayerData;
        }

        private PlayerDataDTO CheckShortCut(PlayerDataDTO playerData)
        {
            foreach(ShortCut cut in _shortCuts)
            {
                if (cut.Start == playerData.Position)
                {
                    //return cut.End;
                    return cut.Calculate(playerData , ExitPoint);
                }
            }
            return playerData;
        }

        

        internal PlayerDataDTO MoveOnBoard(PlayerDataDTO playerData)
        {
            var newPlayerData = CalculateNextPostion(playerData);
            return newPlayerData;
            //return new MoveResult(newPlayerData.Name, playerData.Color, playerData.Position, newPosition , playerData.DiceValue, playerData.Shields);
        }
    }
}
