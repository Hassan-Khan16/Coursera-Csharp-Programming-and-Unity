﻿using System;

namespace Exercise9
{
    /// <summary>
    /// Exercise 9 solution 
    /// </summary>

    internal class Program
    {
        /// <summary>
        /// Demonstrates using custom classes
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // create a new deck and tell the deck to print itself
            Deck deck = new Deck();
            deck.Print();
            Console.WriteLine();

            // tell the deck to shuffle and print itself
            deck.Shuffle();
            deck.Print();

            // take the top card from the deck and print the card rank and suit
            Card card1 = deck.TakeTopCard();
            Console.WriteLine();
            Console.WriteLine("First card: " + card1.Rank + " of " + card1.Suit);

            // take the top card from the deck and print the card rank and suit
            Card card2 = deck.TakeTopCard();
            Console.WriteLine("Second card: "+ card2.Rank+" of "+ card2.Suit);
        }
    }
}
