using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        List<Card> pack;


        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle

            //List of all the Cards that are in a pack
            string[] Cards = { "1Hearts", "1Diamonds", "1Spades", "1Clubs", "2Hearts", "2Diamonds", "2Spades", "2Clubs", "3Hearts", "3Diamonds", "3Spades", "3Clubs", "4Hearts", "4Diamonds", "4Spades", "4Clubs", "5Hearts", "5Diamonds", "5Spades", "5Clubs", "6Hearts", "6Diamonds", "6Spades", "6Clubs", "7Hearts", "7Diamonds", "7Spades", "7Clubs", "8Hearts", "8Diamonds", "8Spades", "8Clubs", "9Hearts", "9Diamonds", "9Spades", "9Clubs", "10Hearts", "10Diamonds", "10Spades", "10Clubs", "11Hearts", "11Diamonds", "11Spades", "11Clubs", "12Hearts", "12Diamonds", "12Spades", "12Clubs", "13Hearts", "13Diamonds", "13Spades", "13Clubs" };

            //Fisher-Yates Shuffle
            if (typeOfShuffle == 1)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First(); //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Top Card From Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a card from the top of the deck

                Cards = Cards.Skip(0).ToArray(); //Get's rid of the top card completly from the deck because it was already played


                return true; //returns the information that the boolean is true


            }

            //Riffle Shuffle
            if (typeOfShuffle == 2)
            {
                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First(); //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Top Card From Riffle Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a card from the top of the deck

                int TopCardI = 0; //assigning an interger as the card in the pack

                Cards = Cards.Where((source, index) => index != TopCardI).ToArray(); //Get's rid of the top card completly from the deck because it was already played 

                return true; //returns the information that the boolean is true


            }

            //No Shuffle
            if (typeOfShuffle == 3)
            {
                return true; //returns the information that the boolean is true
            }

            //Fisher-Yates Shuffle
            if (typeOfShuffle == 4)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First(); //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Card From Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a card from the top of the deck

                int TopCardI = 0; //assigning an interger as the card in the pack

                Cards = Cards.Where((source, index) => index != TopCardI).ToArray(); //Get's rid of the top card completly from the deck because it was already played 

                return true; //returns the information that the boolean is true


            }

            //Fisher-Yates Shuffle
            if (typeOfShuffle == 5)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck

                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 6)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck

                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 7)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3]; //takes the top card from the deck after it has been shuffled 

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck

                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 8)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 9)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck

                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 10)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 11)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7]; //takes the top card from the deck after it has been shuffled 

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 12)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 13)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 14)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 15)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 16)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 17)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 18)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 19)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 20)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 21)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 22)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 23)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 24)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 25)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 26)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 27)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 28)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 29)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 30)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 31)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 32)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 33)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 34)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30]; //takes the top card from the deck after it has been shuffled 

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 35)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 36)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 37)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 38)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 39)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 40)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 41)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 42)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 43)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 44)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 45)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 46)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41] + "," + Cards[42]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 47)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41] + "," + Cards[42] + "," + Cards[43]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 48)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41] + "," + Cards[42] + "," + Cards[43] + "," + Cards[44]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 49)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41] + "," + Cards[42] + "," + Cards[43] + "," + Cards[44] + "," + Cards[45]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 50)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41] + "," + Cards[42] + "," + Cards[43] + "," + Cards[44] + "," + Cards[45] + "," + Cards[46]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 51)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41] + "," + Cards[42] + "," + Cards[43] + "," + Cards[44] + "," + Cards[45] + "," + Cards[46] + "," + Cards[47]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 52)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41] + "," + Cards[42] + "," + Cards[43] + "," + Cards[44] + "," + Cards[45] + "," + Cards[46] + "," + Cards[47] + "," + Cards[48]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 53)
            {

                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41] + "," + Cards[42] + "," + Cards[43] + "," + Cards[44] + "," + Cards[45] + "," + Cards[46] + "," + Cards[47] + "," + Cards[48] + "," + Cards[49]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 54)
            {
                Shuffle(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41] + "," + Cards[42] + "," + Cards[43] + "," + Cards[44] + "," + Cards[45] + "," + Cards[46] + "," + Cards[47] + "," + Cards[48] + "," + Cards[49] + "," + Cards[50];//takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }
            // Depending on what the player's input is the different if statment will actiavte for Fisher-Yates Shuffle

            //Riffle Shuffle
            if (typeOfShuffle == 55)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First(); //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Card From Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a card from the top of the deck

                int TopCardI = 0; //assigning an interger as the card in the pack

                Cards = Cards.Where((source, index) => index != TopCardI).ToArray(); //Get's rid of the top card completly from the deck because it was already played 

                return true; //returns the information that the boolean is true


            }


            if (typeOfShuffle == 56)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck

                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 57)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck

                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 58)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3]; //takes the top card from the deck after it has been shuffled 

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck

                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 59)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 60)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck

                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 61)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 62)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7]; //takes the top card from the deck after it has been shuffled 

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 63)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 64)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 65)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 66)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 67)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 68)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 69)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 70)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 71)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 72)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 73)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 74)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 75)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 76)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 77)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 78)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 79)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 80)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 81)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 82)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 83)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 84)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 85)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30]; //takes the top card from the deck after it has been shuffled 

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 86)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 87)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 88)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 89)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 90)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 91)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 92)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 93)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 94)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 95)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 96)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 97)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41] + "," + Cards[42]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 98)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41] + "," + Cards[42] + "," + Cards[43]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 99)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41] + "," + Cards[42] + "," + Cards[43] + "," + Cards[44]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 100)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41] + "," + Cards[42] + "," + Cards[43] + "," + Cards[44] + "," + Cards[45]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 101)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41] + "," + Cards[42] + "," + Cards[43] + "," + Cards[44] + "," + Cards[45] + "," + Cards[46]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 102)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41] + "," + Cards[42] + "," + Cards[43] + "," + Cards[44] + "," + Cards[45] + "," + Cards[46] + "," + Cards[47]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 103)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41] + "," + Cards[42] + "," + Cards[43] + "," + Cards[44] + "," + Cards[45] + "," + Cards[46] + "," + Cards[47] + "," + Cards[48]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 104)
            {

                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41] + "," + Cards[42] + "," + Cards[43] + "," + Cards[44] + "," + Cards[45] + "," + Cards[46] + "," + Cards[47] + "," + Cards[48] + "," + Cards[49]; //takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }

            if (typeOfShuffle == 105)
            {
                Shufflee(Cards); //uses an algorythm to shuffle the cards

                string TopCard = Cards.First() + "," + Cards[1] + "," + Cards[2] + "," + Cards[3] + "," + Cards[4] + "," + Cards[5] + "," + Cards[6] + "," + Cards[7] + "," + Cards[8] + "," + Cards[9] + "," + Cards[10] + "," + Cards[11] + "," + Cards[12] + "," + Cards[13] + "," + Cards[14] + "," + Cards[15] + "," + Cards[16] + "," + Cards[17] + "," + Cards[18] + "," + Cards[19] + "," + Cards[20] + "," + Cards[21] + "," + Cards[22] + "," + Cards[23] + "," + Cards[24] + "," + Cards[25] + "," + Cards[26] + "," + Cards[27] + "," + Cards[28] + "," + Cards[29] + "," + Cards[30] + "," + Cards[31] + "," + Cards[32] + "," + Cards[33] + "," + Cards[34] + "," + Cards[35] + "," + Cards[36] + "," + Cards[37] + "," + Cards[38] + "," + Cards[39] + "," + Cards[40] + "," + Cards[41] + "," + Cards[42] + "," + Cards[43] + "," + Cards[44] + "," + Cards[45] + "," + Cards[46] + "," + Cards[47] + "," + Cards[48] + "," + Cards[49] + "," + Cards[50];//takes the top card from the deck after it has been shuffled

                Console.WriteLine("Next Cards from Fisher-Yates Shuffle: {0}", string.Join(",", TopCard)); //Prints outs a cards from the top of the deck


                return true; //returns the information that the boolean is true

            }
            // Depending on what the player's input is the different if statment will actiavte for Riffle Shuffle
            

            else
            {
                return false; //returns the information that the boolean is false because there are only 3 types of shuffles
            }

        }

        static Random randomn = new Random(); //Random method used for the algorythm

        static void Shuffle<T>(T[] array) //Algorythm to calcualte Fisher-Yates Shuffle
        {
            int n = array.Length; //Checks how many cards are in the pack

            for (int i = 0; i < (n - 1); i++) //Does this algorythm 52 times because that is how many cards are in a pack
            {
                int r = i + randomn.Next(n - i); //Picks a random non negative number between 1-52 and takes it away

                T t = array[r];

                array[r] = array[i];

                array[i] = t;


            }

        }

        static void Shufflee<T>(T[] array) //Algorythm to calcualte Riffle Shuffle
        {
            T[] shuffledArray = new T[array.Length]; //Checks how many cards are in the pack
            int halfArraySize = array.Length / 2; // Devides the number of cards in the pack by 2 so you are left with half;
            int j = 0;

            for (int i = 0; i < halfArraySize; i++)
            {
                shuffledArray[j++] = array[i];
                shuffledArray[j++] = array[i + halfArraySize];
            }

            if (array.Length % 2 != 0)
            {
                shuffledArray[j] = array[array.Length - 1];
            }

            Array.Copy(shuffledArray, array, array.Length);
        }


    }
}
