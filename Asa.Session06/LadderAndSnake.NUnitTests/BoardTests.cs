using LadderAndSnake.DTO;
using LadderAndSnake.Shortcuts;
using NUnit.Framework;

namespace LadderAndSnake.NUnitTests
{
    public class BoardTests
    {
        [SetUp]
        public void Setup()
        {
            
        }


        [Test]
        public void AddShortCut_SnakeLadderNotCompatible_ThrowsException()
        {
            BoardDataDto boardData = new BoardDataDto();

            //Arrange
            boardData.Height = 2;
            boardData.Width = 2;
            Board board = new Board(boardData);
            ShortCut ladder = new RegularShortCut(1, 3);
            ShortCut snake = new RegularShortCut(4, 2);
            board.AddLadderToBoard(ladder);
            

            //Assert
            Assert.That(() => board.AddSnakeToBoard(snake), Throws.Exception);
        }

        [Test]
        public void AddShortCut_ValidateShortCutsOverlap_ThrowsException()
        {
            BoardDataDto boardData = new BoardDataDto();

            //Arrange
            boardData.Height = 2;
            boardData.Width = 10;
            Board board = new Board(boardData);
            ShortCut ladder = new RegularShortCut(1, 3);
            ShortCut snake = new RegularShortCut(1, 2);
            board.AddLadderToBoard(ladder);


            Assert.That(() => board.AddSnakeToBoard(snake), Throws.Exception);
        }

        [Test]
        public void CalculateNextPosition_NextPositionIsLadder_ReturnsRightValue()
        {
            BoardDataDto boardData = new BoardDataDto();
            //Arrange
            boardData.Height = 2;
            boardData.Width = 10;
            Board board = new Board(boardData);
            board.AddLadderToBoard(new RegularShortCut(2,5));
            var playerData = new PlayerDataDTO();
            playerData.Position = 1;
            playerData.DiceValue = 1;
            playerData.Shields = 0;
            var x = board.CalculateNextPostion(playerData).Position;

            Assert.AreEqual(5, x);
        }

        [Test]
        public void CalculateNextPosition_NextPositionExceedsExitPoint_ReturnsSamePosition()
        {
            BoardDataDto boardData = new BoardDataDto();
            //Arrange
            boardData.Height = 2;
            boardData.Width = 10;
            Board board = new Board(boardData);
            var playerData = new PlayerDataDTO();
            playerData.Position = 18;
            playerData.DiceValue = 5;
            playerData.Shields = 0;
            var pos = board.CalculateNextPostion(playerData).Position;

            Assert.AreEqual(18, pos);
        }

        [Test]
        public void CalculateNextPosition_RegularCalculation_ReturnsPositionPlusDice()
        {
            BoardDataDto boardData = new BoardDataDto();
            //Arrange
            boardData.Height = 2;
            boardData.Width = 10;
            Board board = new Board(boardData);
            var playerData = new PlayerDataDTO();
            playerData.Position = 1;
            playerData.DiceValue = 5;
            playerData.Shields = 0;
            var pos = board.CalculateNextPostion(playerData).Position;

            Assert.AreEqual(6, pos);
        }
    }
}