﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oreilly_Csharp_ch8_enum_P355
{
    enum Suits
    {
        Spades,        Clubs,        Diamonds,        Hearts,
    }
    enum Values
    {
        Ace = 1,        Two = 2,        Three = 3,        Four = 4,        Five = 5,
        Six = 6,        Seven = 7,        Eight =8 ,        Nine = 9,        Ten = 10,
        Jack = 11,        Queen = 12,        king = 13,
    }

    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public string Name
        {
            get
            {
                return Value.ToString() + " of " + Suit.ToString();
            }
        }
    }    
}