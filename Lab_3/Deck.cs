﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    /**
     * <summary>
     * This class extends the List<Card> generic type
     * </summary>
     * 
     * @class Deck
     */
    class Deck : List<Card>
    {

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method loads a list of cards with Card objects
         * </summary>
         * 
         * @private
         * @method _create
         * @returns {void}
         */
        private void _create()
        {
            string suit = "";

            for (int suitIndex = 0; suitIndex < 4; suitIndex++)
            {
                switch (suitIndex)
                {
                    case 0:
                        suit = "spades";
                        break;
                    case 1:
                        suit = "hearts";
                        break;
                    case 2:
                        suit = "clubs";
                        break;
                    case 3:
                        suit = "diamonds";
                        break;

                } // end suit switch

                for (int face = 1; face < 14; face++)
                {
                    this.Add(new Card(face, suit)); // anonymous Card object to the list
                } // end for - face

            } // end for - suit

        } // end CreateDeck method

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This is the default constructor for the Deck class
         * </summary>
         * 
         * @constructor Deck
         */
        public Deck()
        {
            // create my deck of cards
            this._create();
        }

        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * This method displays a List of Card objects to the Console
         * </summary>
         * 
         * @method Display
         * @returns {void}
         */
        public void Display()
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+ Current Deck                              +");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
            foreach (Card card in this)
            {
                Console.WriteLine("{0} of {1}", card.Face, card.Suit);
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }

        /**
         * <summary>
         * This method randomly shuffles a List of Card objects
         * </summary>
         * 
         * @method Shuffle
         * @returns {void}
         */
        public void Shuffle()
        {
            // creates a pseudo-random number sequence and stores it in random
            Random random = new Random();
            // record the number of cards in the deck List
            int cardCount = this.Count;

            // iterate through the list of cards 
            for (int currentCard = 0; currentCard < cardCount; currentCard++)
            {
                Card tempCard = this[currentCard]; // copy current card to temp location
                int randomCard = random.Next(0, cardCount); // get a random card index
                this[currentCard] = this[randomCard]; // copy value from randomCard to currentCard
                this[randomCard] = tempCard; // copy current card to random card
            }

        }

        /**
         * <summary>
         * This method will remove the 0th item from the deck and return it to the caller
         * </summary>
         * 
         * @method Deal
         * @returns {Card}
         */
        public Card Deal()
        {
            Card returnedCard = this[0]; // copy the 0th card in the stack to the returnedCard

            // check to see if the deck is not empty
            if (this.Count > 0)
            {
                this.RemoveAt(0); // remove the 0th Card from deck
            }

            return returnedCard;
        }
    }
}
