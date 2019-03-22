using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RpgDataEngine.DiceEngine;

namespace RpgDataEngine.Controllers
{
    [Route("api/[controller]")]
    public class DiceController : Controller
    {
        [HttpGet("[action]")]
        public int Roll(int faceCount = 20)
        {
            return new DiceCollection(1, faceCount).RollAll();
        }

        [HttpGet("[action]")]
        public IEnumerable<int> RollIndividual(int faceCount = 20, int diceCount = 1)
        {
            return new DiceCollection(diceCount, faceCount).RollAllIndividual();
        }

        [HttpGet("[action]")]
        public int RollCombination()
        {
            throw new NotImplementedException();

            var combination = new DiceCombination();
            for(int i = 0; i < 10; i++)
            {
                combination.Dice.Add(new DiceCollection(i + 2, i + 2));
            }

            return combination.RollAll();
        }

        [HttpGet("[action]")]
        public IEnumerable<int> RollCombinationIndividual()
        {
            throw new NotImplementedException();
            
            var combination = new DiceCombination();
            for(int i = 0; i < 10; i++)
            {
                combination.Dice.Add(new DiceCollection(i + 2, i + 2));
            }

            return combination.RollAllIndividual();
        }
    }
}