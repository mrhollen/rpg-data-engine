using System;

namespace RpgDataEngine.DiceEngine
{
    public class Die
    {
        public static int Roll(int faceCount, Random random = null)
        {
            if(random == null) 
            {
                random = new Random();
            }

            return random.Next(1, faceCount + 1);
        }
    }
}