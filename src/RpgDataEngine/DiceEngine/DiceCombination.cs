using System.Collections.Generic;

namespace RpgDataEngine.DiceEngine
{
    public class DiceCombination
    {
        public List<DiceCollection> Dice { get; set; } = new List<DiceCollection>();

        public int RollAll()
        {
            var total = 0;
            foreach(var die in Dice)
            {
                total += die.RollAll();
            }
            return total;
        }

        public IEnumerable<int> RollAllIndividual()
        {
            List<int> values = new List<int>();
            foreach(var die in Dice)
            {
                values.AddRange(die.RollAllIndividual());
            }

            return values;
        }
    }
}