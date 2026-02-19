using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    // Card class representing a playing card
    public class Card
    {
        // Default Card constructor      
        public Suit Suit { get; set; } // Suit property
        public Face Face { get; set; } // Face property
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    public enum Suit
    {
        Clubs,           
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
