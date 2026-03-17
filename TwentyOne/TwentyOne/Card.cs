using System;

namespace TwentyOne
{
    public class Card
    {
        // Properties for the Card class
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        // Overriding ToString() allows us to print the card easily
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }

    // Enums to limit the values a card can have
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
    }
}