using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RpgDataEngine.DiceEngine;

namespace RpgDataEngine.Controllers
{
    [Route("api/[controller]")]
    public class DiceController : Controller
    {
        [HttpGet("[action]")]
        public IActionResult Roll(int faceCount = 20)
        {
            return Ok(new DiceCollection(1, faceCount).RollAll());
        }

        [HttpGet("[action]")]
        public IActionResult RollIndividual(int faceCount = 20, int diceCount = 1)
        {
            return Ok(new DiceCollection(diceCount, faceCount).RollAllIndividual());
        }

        [HttpGet("[action]")]
        public IActionResult RollCombination()
        {
            return NotFound();

            var combination = new DiceCombination();
            for(int i = 0; i < 10; i++)
            {
                combination.Dice.Add(new DiceCollection(i + 2, i + 2));
            }

            return Ok(combination.RollAll());
        }

        [HttpGet("[action]")]
        public IActionResult RollCombinationIndividual()
        {
            return NotFound();
            
            var combination = new DiceCombination();
            for(int i = 0; i < 10; i++)
            {
                combination.Dice.Add(new DiceCollection(i + 2, i + 2));
            }

            return Ok(combination.RollAllIndividual());
        }
    }
}