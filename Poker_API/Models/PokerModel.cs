using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poker_API.Models
{
    public class Card
    {
        public string Rank { get; set; }
        public string Suit { get; set; }
    }

    public class AnalyzedCard
    {
        public int Value { get; set; }
        public string Suit { get; set; }
    }
}
