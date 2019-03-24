using System;
using Xunit;
using RpgDataEngine.DiceEngine;

namespace DiceEngine.Tests
{
    public class DiceCollectionTests
    {
        [Theory]
        [InlineData(1, 6)]
        [InlineData(2, 6)]
        [InlineData(1, 20)]
        [InlineData(2, 20)]
        public void DiceCollectionRollShouldBeWithinRange(int diceCount, int diceFaceCount)
        {
            // Setup
            var diceCollection = new DiceCollection(diceCount, diceFaceCount);

            // Test
            var roll = diceCollection.RollAll();

            // Assert
            Assert.InRange(roll, diceCount, diceCount * diceFaceCount);
        }
    }
}
