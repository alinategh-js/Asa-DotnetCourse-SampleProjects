using LadderAndSnake.Enums;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LadderAndSnake.NUnitTests
{
    public class GameTests
    {
        Game game;
        [SetUp]
        public void Setup()
        {
            game = new Game(4, 5);
        }

        [Test]
        public void Join_DuplicatedPlayerName_ThrowsException()
        {
            game.Join("Ali", ColorEnum.Red);

            Assert.That(() => game.Join("Ali", ColorEnum.Yellow), Throws.InvalidOperationException);
        }

        [Test]
        public void Join_DuplicatedPlayerColor_ThrowsException()
        {
            game.Join("Ali", ColorEnum.Blue);

            Assert.That(() => game.Join("Mohammad", ColorEnum.Blue), Throws.InvalidOperationException);
        }

        //[Test]
        //public void Play_GameIsFinished_ThrowsException()
        //{
        //    game.Join("Ali", ColorEnum.Red);
        //    game.Join("Mohammad", ColorEnum.Blue);
        //    //Assert
        //    Assert.That(() => game.Play(), Throws.InvalidOperationException);
        //}

        [Test]
        public void AddSnake_StartAndEndAreEqual_ThrowsException()
        {
            Assert.That(() => game.AddSnake(4, 4, ShortCutType.Regular), Throws.Exception);
        }

        [Test]
        public void AddSnake_StartSmallerThanEnd_ThrowsException()
        {
            Assert.That(() => game.AddSnake(2, 6, ShortCutType.Regular), Throws.Exception);
        }

        [Test]
        public void AddLadder_StartAndEndAreEqual_ThrowsException()
        {
            Assert.That(() => game.AddLadder(4, 4, ShortCutType.Regular), Throws.Exception);
        }

        [Test]
        public void AddSnake_StartGreaterThanEnd_ThrowsException()
        {
            Assert.That(() => game.AddLadder(6, 2, ShortCutType.Regular), Throws.Exception);
        }

        
    }
}
