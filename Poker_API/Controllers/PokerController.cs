using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Poker_API.Services;
using Poker_API.Models;

namespace Poker_API.Controllers
{
    [Route("api/Poker")]
    [ApiController]
    public class PokerController : Controller
    {
        public readonly PokerService _pokerService;

        public PokerController(PokerService pokerService)
        {
            _pokerService = pokerService;
        }

        [HttpPost("PokerHandRanking")]
        public IActionResult PokerHandRanking(List<Card> PokerHand)
        {
            string error = "";
            string str_Result = _pokerService.PokerCombinationResult(PokerHand, ref error);
            if (string.IsNullOrEmpty(error)) { return Ok(str_Result); }
            else { return Ok(error); }
        }
    }
}
