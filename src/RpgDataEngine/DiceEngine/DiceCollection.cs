using System;
using System.Collections.Generic;

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

        public int RollAll()
        {
            var total = 0;
            var random = new Random();

            for(int i = 0; i < DiceCount; i++)
            {
                total += Die.Roll(DiceFaceCount, random);
            }

            return total;
        }

        public IEnumerable<int> RollAllIndividual()
        {
            var rolls = new int[DiceCount];
            var random = new Random();

            for(int i = 0; i < DiceCount; i++)
            {
                rolls[i] = Die.Roll(DiceFaceCount, random);
            }

            return rolls;
        }
    }
}