using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
         * @method main
         * @parm {string[]} args
         */

        public static void Main(string[] args)
        {
            //create instance of student
            
            List<Card> Deck = new List<Card>();


            CreateDeck(Deck);
        }

        public static void CreateDeck(List<Card> deck)
        {
            string suit = "";
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        suit = "hearts";
                        break;
                    case 1:
                        suit = "clubs";
                        break;
                    case 2:
                        suit = "diamonds";
                        break;
                    case 3:
                        suit = "spades";
                        break;


                }


                for (int face = 1; face < 14; face++)
                {
                    deck.Add(new Card(face, suit));
                }
            }


            /**       MyList myList = new MyList();
                   myList.Add(1);
                   myList.Add(5);
                   myList.Clear();
                   myList.Print();  */
        }
    }
}

