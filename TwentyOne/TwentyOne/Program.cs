using System;
using System.Collections.Generic;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Deck deck = new Deck();
            deck.Shuffle(3); // Shuffles the deck 3 times

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card); // Uses the overridden ToString()
            }

            Console.WriteLine("\nTotal Cards: " + deck.Cards.Count);
            Console.ReadLine();
        }
    }
}