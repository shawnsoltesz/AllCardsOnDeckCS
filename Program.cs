﻿using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //var deckOfCards = new List<string>() { "Ace of Hearts", "2 of Hearts", "3 of Hearts", "4 of Hearts", "5 of Hearts", "6 of Hearts", "7 of Hearts", "8 of Hearts", "9 of Hearts", "10 of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts", "Ace of Clubs", "2 of Clubs", "3 of Clubs", "4 of Clubs", "5 of Clubs", "6 of Clubs", "7 of Clubs", "8 of Clubs", "9 of Clubs", "10 of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs", "Ace of Diamonds", "2 of Diamonds", "3 of Diamonds", "4 of Diamonds", "5 of Diamonds", "6 of Diamonds", "7 of Diamonds", "8 of Diamonds", "9 of Diamonds", "10 of Diamonds", "Jack of Diamonds", "Queen of Diamonds", "King of Diamonds", "Ace of Spades", "2 of Spades", "3 of Spades", "4 of Spades", "5 of Spades", "6 of Spades", "7 of Spades", "8 of Spades", "9 of Spades", "10 of Spades", "Jack of Spades", "Queen of Spades", "King of Spades" };

            //var numberOfCards = deckOfCards.Count;
            //Console.WriteLine(numberOfCards);


            //for rightIndex from numberOfCards - 1 down to 1 do:

            var suits = new List<string>() { "Hearts", "Spades", "Clubs", "Diamonds", };

            var rank = new List<string>() { "Ace", "2", "2", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", };

            var deck = new List<string>();



            //for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
            {


                //leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer")
                //var randomNumberGenerator = new Random();
                //var leftIndex = randomNumberGenerator.Next(rightIndex);
                //Console.WriteLine(leftIndex);

                //Now swap the values at rightIndex and leftIndex by doing this:
                //leftCard = the value from deck[leftIndex]
                //var leftCard = deckOfCards[leftIndex];


                //rightCard = the value from deck[rightIndex]
                //var rightCard = deckOfCards[rightIndex];
                //Console.WriteLine(rightIndex);



                //deck[rightIndex] = leftCard
                //deckOfCards[rightIndex] = leftCard;
                //Console.WriteLine(leftCard);


                //deck[leftIndex] = rightCard
                //deckOfCards[leftIndex] = rightCard;
                //Console.WriteLine(rightCard);

            }

            //var firstCard = deckOfCards[0];
            //Console.WriteLine(firstCard);
            //git add .Console.WriteLine($"The first card is: {firstCard}");


            //var secondCard = deckOfCards[1];
            //Console.WriteLine(secondCard);
            //Console.WriteLine($"The second card is: {secondCard}");

            //Console.WriteLine($"The first card is: {firstCard}, and the second card is {secondCard}");

            //leaving code to try and figure out looping and generating the cards vs static list
            //var suit = new List<string>() { "Clubs", "Diamonds", "Hearts", "Spades" };
            //var rank = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            //var deckOfCards = new List<string>() { $"{suit} of {rank}" };

            //Console.WriteLine(deckOfCards);





        }
    }
}