using System;
using ConsoleCards;

namespace ProgrammingAssignment3
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 3
    /// </summary>
    class Program
    {
        /// <summary>
        /// Programming Assignment 3
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                // declare a deck variables and create a deck object
                Deck deck = new Deck();
                // DON'T SHUFFLE THE DECK

                // deal 2 cards each to 4 players (deal properly, dealing
                // the first card to each player before dealing the
                // second card to each player)
                Card p1 = deck.TakeTopCard();
                Card p2 = deck.TakeTopCard();
                Card p3 = deck.TakeTopCard();
                Card p4 = deck.TakeTopCard();
                Card p11 = deck.TakeTopCard();
                Card p22 = deck.TakeTopCard();
                Card p33 = deck.TakeTopCard();
                Card p44 = deck.TakeTopCard();
                // deal 1 more card to players 2 and 3
                Card p222 = deck.TakeTopCard();
                Card p333 = deck.TakeTopCard();
                // flip all the cards over
                p1.FlipOver();
                p11.FlipOver();
                p2.FlipOver();
                p22.FlipOver();
                p222.FlipOver();
                p3.FlipOver();
                p33.FlipOver();
                p333.FlipOver();
                p4.FlipOver();
                p44.FlipOver();
                // print the cards for player 1
                Console.WriteLine(p1.Rank + "," + p1.Suit);
                Console.WriteLine(p11.Rank + "," + p11.Suit);
                // print the cards for player 2
                Console.WriteLine(p2.Rank + "," + p2.Suit);
                Console.WriteLine(p22.Rank + "," + p22.Suit);
                Console.WriteLine(p222.Rank + "," + p222.Suit);
                // print the cards for player 3
                Console.WriteLine(p3.Rank + "," + p3.Suit);
                Console.WriteLine(p33.Rank + "," + p33.Suit);
                Console.WriteLine(p333.Rank + "," + p333.Suit);
                // print the cards for player 4
                Console.WriteLine(p4.Rank + "," + p4.Suit);
                Console.WriteLine(p44.Rank + "," + p44.Suit);
                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }
    }
}
