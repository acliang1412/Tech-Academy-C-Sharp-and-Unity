using System;
using System.Collections.Generic;

namespace TwentyOne
{
    public class Deck
    {
        // The Deck class "has a" list of Cards
        public List<Card> Cards { get; set; }

        // Constructor: This runs as soon as you say "new Deck()"
        public Deck()
        {
            Cards = new List<Card>();

            // Nested loop to create all 52 combinations
            for (int i = 0; i < 4; i++) // 4 Suits
            {
                for (int j = 0; j < 13; j++) // 13 Faces
                {
                    Card card = new Card();
                    card.Suit = (Suit)i; // Casting the integer to the Suit enum
                    card.Face = (Face)j; // Casting the integer to the Face enum
                    Cards.Add(card);
                }
            }
        }

        // Method to shuffle the deck
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                this.Cards = TempList;
            }
        }
    }
}