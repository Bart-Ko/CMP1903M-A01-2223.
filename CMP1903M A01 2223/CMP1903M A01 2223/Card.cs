using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public int Value;

        public int Suit;

        public int card_value
        {
            get { return Value; }

            set
            {
                if (0 < value && value < 14) // Makes sure that the value of a card is between 1 and 13
                {
                    Value = value;
                }

                else
                {
                    Console.WriteLine("Value needs to be between 1-13"); // If it's not between 1 and 13 print out a message that the value needs to be between 1-13
                }

            }
        }


        public int card_suit
        {
            get { return Suit; }

            set
            {
                if (0 < value && value < 5) // Makes sure that the suit of a card is between 1 and4
                {
                    Suit = value;
                }

                else
                {
                    Console.WriteLine("Suit needs to be between 1-4"); // If it's not between 1 and 4 print out a message that the suit needs to be between 1-13
                }

            }
        }
    }

}
