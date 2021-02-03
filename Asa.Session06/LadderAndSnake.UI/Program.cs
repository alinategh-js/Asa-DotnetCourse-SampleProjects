using LadderAndSnake.Enums;
using System;
using System.Collections.Generic;

namespace LadderAndSnake.UI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            try
            {
                Game g = new Game(5, 4);
                AddLadderAndSnake();
                g.Join("Ali", ColorEnum.Red);
                g.Join("Nastaran", ColorEnum.Blue);
                g.Join("Mohammad", ColorEnum.Green);
                g.Join("Zahra", ColorEnum.Yellow);

                MoveResult result;

                void AddLadderAndSnake()
                {
                    g.AddSnake(11, 2, ShortCutType.Regular);
                    g.AddLadder(4, 10, ShortCutType.Regular);
                    g.AddSnake(12, 5, ShortCutType.Regular);
                }

                while (true)
                {
                    Console.WriteLine("Press Any Key To Play A Round...");
                    Console.ReadLine();
                    result = g.Play();
                    Console.WriteLine($"Player {result.Name} with Color: {result.Color} rolled dice with result: {result.DiceValue}");
                    Console.WriteLine($"Move from position: {result.OldPosition} to {result.NewPosition}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            
        }
    }
}
