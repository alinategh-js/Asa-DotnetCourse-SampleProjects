using System;
using LadderAndSnake.DTO;

namespace LadderAndSnake
{
    public class Player
    {
        public string Name { get; }
        public int Position { get; private set; } = 1;
        public int Shields { get; private set; } = 0;
        public ColorEnum Color { get; }
        public int DiceValue { get; private set; }

        public Player(string name, ColorEnum color)
        {
            Name = name != null ? name.Trim().ToLower() : throw new ArgumentNullException(nameof(name));
            Color = color;
        }
        public int RollDice() // Not Testable because of Random
        {
            var randomGenerator = new Random();
            var randomNumber = randomGenerator.Next(1, 1000);
            var diceValue = (randomNumber % 6) + 1;
            return diceValue;
        }
        public override bool Equals(object obj)
        {

            if (obj is Player player)
            {
                var namesAreTheSame = string.Compare(Name, player.Name, true) == 0;
                var colorsAreTheSame = Color == player.Color;
                return namesAreTheSame || colorsAreTheSame;
            }
            return false;
        }
        public override int GetHashCode()
        {
            //https://docs.microsoft.com/en-us/visualstudio/ide/reference/generate-equals-gethashcode-methods?view=vs-2019
            return HashCode.Combine(this.Name, this.Color);
        }
        public static bool operator ==(Player p1, Player p2) => p1.Equals(p2);
        public static bool operator !=(Player p1, Player p2) => !p1.Equals(p2);

        internal MoveResult MoveOn(Board board)
        {
            DiceValue = RollDice();
            var oldPosition = Position;
            //var newPosition = board.CalculateNextPostion(oldPosition, diceValue);
            PlayerDataDTO playerData = SetPlayerData();
            PlayerDataDTO newPlayerData = board.MoveOnBoard(playerData);
            //Position = newPosition;
            Position = newPlayerData.Position;
            Shields = newPlayerData.Shields;
            return new MoveResult(Name, Color, oldPosition, Position, DiceValue, Shields);
        }

        private PlayerDataDTO SetPlayerData()
        {
            var playerData = new PlayerDataDTO();
            playerData.DiceValue = RollDice();
            playerData.Position = Position;
            playerData.Shields = Shields;
            return playerData;
        }
    }
}
