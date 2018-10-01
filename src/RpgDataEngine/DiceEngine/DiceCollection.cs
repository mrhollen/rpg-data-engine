using System;

namespace RpgDataEngine.DiceEngine
{
    public class DiceCollection
    {
        public DiceCollection(){}

        public DiceCollection(int diceCount, int diceFaceCount)
        {
            this.DiceCount = diceCount;
            this.DiceFaceCount = diceFaceCount;
        }

        public int DiceCount { get; set; }

        public int DiceFaceCount { get; set; }

        public int Roll()
        {
            var total = 0;
            var random = new Random();

            for(int i = 0; i < DiceCount; i++)
            {
                total += random.Next(1, DiceFaceCount + 1);
            }

            return total;
        }
    }
}