using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using LadderAndSnake.Enums;
using LadderAndSnake.Shortcuts;

namespace LadderAndSnake
{
    public class Game
    {

        readonly List<Player> _players;
        Board _board;
        int _currentPlayerIndex = 0;
        const int Max_Allowd_Players = 4;


        #region Constructors
        public Game(int heigth, int width)
        {
            BoardDataDto boardData = new BoardDataDto();
            boardData.Height = heigth;
            boardData.Width = width;
            //boardData.Ladders = ladders;
            //boardData.Snakes = snakes;
            _board = new Board(boardData);
            _players = new List<Player>();
        }

        //public Game()
        //{
        //    _players = new List<Player>();
        //}
        #endregion


        public void Join(string name, ColorEnum color)
        {
            //foreach (var item in _players)
            //{
            //    if (item.Name == name) throw new InvalidOperationException("Duplicated player name is not allowed.");
            //}

            //IComparable<T>
            Player newPlayer = new Player(name, color);
            //if (_players.Any(x => x.Name.ToLower().Trim() == name.ToLower().Trim() || x.Color == color))
            //if (_players.Any(x => x.Equals(newPlayer)))


            if (_players.Any(x => x == newPlayer))
            {
                throw new InvalidOperationException("Duplicated player is not allowed.");
            } //  NOTE: BECAUSE WE HAVE AN ENUM FOR COLORS, ONLY 4 PLAYERS CAN JOIN THE GAME.
              // THEREFORE THERE IS NO NEED TO CHECK MAX_ALLOWED_PLAYERS


            //if (_players.Count >= Max_Allowd_Players)
            //{
            //    throw new InvalidOperationException("Only 4 players can join a game.");
            //}
            _players.Add(newPlayer);
        }


        bool gameIsFinished;
        public MoveResult Play()
        {
            if (gameIsFinished)
            {
                throw new InvalidOperationException("Game is finished, no more movement is allowed.");
            }
            var currentPlayer = GetCurrentPlayer();
            MoveResult moveresult = currentPlayer.MoveOn(_board);
            moveresult.IsWinner = moveresult.NewPosition == _board.ExitPoint;
            gameIsFinished = moveresult.IsWinner;
            if (_currentPlayerIndex < Max_Allowd_Players - 1) _currentPlayerIndex++;
            else _currentPlayerIndex = 0;
            return moveresult;
        }

        private Player GetCurrentPlayer() => _players[_currentPlayerIndex];

        public void AddSnake(int start, int end, ShortCutType type)
        {
            if (start == end) throw new Exception("Start and End cannot be the same.");
            if (start < end) throw new Exception("Snake's start should not be greater than it's end.");
            var snake = AddShortCut(start, end, type);
            _board.AddSnakeToBoard(snake);
        }

        public void AddLadder(int start, int end, ShortCutType type)
        {
            if (start == end) throw new Exception("Start and End cannot be the same.");
            if (start > end) throw new Exception("Ladders's start should not be smaller than it's end.");
            var ladder = AddShortCut(start, end, type);
            _board.AddLadderToBoard(ladder);
        }
       

        private ShortCut AddShortCut(int start, int end, ShortCutType type)
        {
            if(type == ShortCutType.Regular)
            {
                return new RegularShortCut(start, end);
            }
            else if(type == ShortCutType.ShieldShortCut)
            {
                return new ShieldShortCut(start, end);
            }
            else if(type == ShortCutType.WinShortCut)
            {
                return new WinShortCut(start, end);
            }
            return new RegularShortCut(start, end);
        }
    }
}
