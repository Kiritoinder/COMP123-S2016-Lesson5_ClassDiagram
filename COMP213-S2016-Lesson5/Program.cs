using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* Author: Inderjeet Singh
* Student Number: 300874118
* Date: June 10, 2016
* Date Modified: June 10, 2016
* Description: Deal a card
* Version: 0.0.1
*/
namespace COMP213_S2016_Lesson5
{
    /**
     * this class is the "driver" class for our program
     * @class program
     */
    public class Program
    {
        /**
         * the main method for driver class
         * 
         * @method Main
         * @param {sting[]}args
         * @returns {void}
         */
        public static void Main(string[] args)
        {

            Deck deck = new Deck(); // create a deck of cards
            deck.Display(); // display the initial state of the deck

            deck.Shuffle(); // shuffle the deck
            deck.Display(); // display the deck after shuffling}


            Card cardDealt = deck.Deal();
            Console.WriteLine("Card Delt: {0} of {1}", cardDealt.Face, cardDealt.Suit);
            Console.WriteLine();
            deck.Display();

        } // end Main



    } // end Program

} // end namespace