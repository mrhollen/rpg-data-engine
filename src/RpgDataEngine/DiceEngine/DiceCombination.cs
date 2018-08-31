using System;

namespace RpgDataEngine.DiceEngine
{
    public class DiceCombination
    {
        public int DiceCount { get; set; }

        public int DiceSideCount { get; set; }

        public int Roll()
        {
            var total = 0;
            var random = new Random();

            for(int i = 0; i < DiceCount; i++)
            {
                total += random.Next(1, DiceSideCount + 1);
            }

            return total;
        }
    }
}