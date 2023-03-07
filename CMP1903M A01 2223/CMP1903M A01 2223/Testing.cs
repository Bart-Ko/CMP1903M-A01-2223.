using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Testing
    {
        public Testing()
        {

            if (Pack.shuffleCardPack(1)) //checks the shufflecardpack method for the number 1 and calls it
            {
                Console.WriteLine("Fisher-Yates Shuffle works"); //write a message that the Fisher-Yates Shuffle works 
            }

            int intVal;

            string userInput;

            Console.Write("How many Cards you want? (max51)"); //Asks the user how many Cards would he like from the fisher-yates shuffle

            userInput = Console.ReadLine();

            intVal = Convert.ToInt32(userInput);

            if (intVal < 0)
            {
                Console.WriteLine("The minimum amount is 0");

            }

            if (intVal == 1)
            {
                Pack.shuffleCardPack(4);
            }

            if (intVal == 2)
            {
                Pack.shuffleCardPack(5);
            }

            if (intVal == 3)
            {
                Pack.shuffleCardPack(6);
            }

            if (intVal == 4)
            {
                Pack.shuffleCardPack(7);
            }

            if (intVal == 5)
            {
                Pack.shuffleCardPack(8);
            }

            if (intVal == 6)
            {
                Pack.shuffleCardPack(9);
            }

            if (intVal == 7)
            {
                Pack.shuffleCardPack(10);
            }

            if (intVal == 8)
            {
                Pack.shuffleCardPack(11);
            }

            if (intVal == 9)
            {
                Pack.shuffleCardPack(12);
            }

            if (intVal == 10)
            {   
                Pack.shuffleCardPack(13);
            }
            if (intVal == 11)
            {
                Pack.shuffleCardPack(14);
            }

            if (intVal == 12)
            {
                Pack.shuffleCardPack(15);
            }

            if (intVal == 13)
            {
                Pack.shuffleCardPack(16);
            }

            if (intVal == 14)
            {
                Pack.shuffleCardPack(17);
            }

            if (intVal == 15)
            {
                Pack.shuffleCardPack(18);
            }

            if (intVal == 16)
            {
                Pack.shuffleCardPack(19);
            }

            if (intVal == 17)
            {
                Pack.shuffleCardPack(20);
            }

            if (intVal == 18)
            {
                Pack.shuffleCardPack(21);
            }

            if (intVal == 19)
            {
                Pack.shuffleCardPack(22);
            }

            if (intVal == 20)
            {
                Pack.shuffleCardPack(23);
            }

            if (intVal == 21)
            {
                Pack.shuffleCardPack(24);
            }

            if (intVal == 22)
            {
                Pack.shuffleCardPack(25);
            }

            if (intVal == 23)
            {
                Pack.shuffleCardPack(26);
            }

            if (intVal == 24)
            {
                Pack.shuffleCardPack(27);
            }

            if (intVal == 25)
            {
                Pack.shuffleCardPack(28);
            }

            if (intVal == 26)
            {
                Pack.shuffleCardPack(29);
            }

            if (intVal == 27)
            {
                Pack.shuffleCardPack(30);
            }

            if (intVal == 28)
            {
                Pack.shuffleCardPack(31);
            }

            if (intVal == 29)
            {
                Pack.shuffleCardPack(32);
            }

            if (intVal == 30)
            {
                Pack.shuffleCardPack(33);
            }

            if (intVal == 31)
            {
                Pack.shuffleCardPack(34);
            }

            if (intVal == 32)
            {
                Pack.shuffleCardPack(35);
            }

            if (intVal == 33)
            {
                Pack.shuffleCardPack(36);
            }

            if (intVal == 34)
            {
                Pack.shuffleCardPack(37);
            }

            if (intVal == 35)
            {
                Pack.shuffleCardPack(38);
            }

            if (intVal == 36)
            {
                Pack.shuffleCardPack(39);
            }

            if (intVal == 37)
            {
                Pack.shuffleCardPack(40);
            }

            if (intVal == 38)
            {
                Pack.shuffleCardPack(41);
            }

            if (intVal == 39)
            {
                Pack.shuffleCardPack(42);
            }

            if (intVal == 40)
            {
                Pack.shuffleCardPack(43);
            }
            if (intVal == 41)
            {   
                Pack.shuffleCardPack(44);
            }

            if (intVal == 42)
            {
                Pack.shuffleCardPack(45);
            }

            if (intVal == 43)
            {
                Pack.shuffleCardPack(46);
            }

            if (intVal == 44)
            {
                Pack.shuffleCardPack(47);
            }

            if (intVal == 45)
            {
                Pack.shuffleCardPack(48);
            }

            if (intVal == 46)
            {
                Pack.shuffleCardPack(49);
            }

            if (intVal == 47)
            {
                Pack.shuffleCardPack(50);
            }

            if (intVal == 48)
            {
                Pack.shuffleCardPack(51);
            }

            if (intVal == 49)
            {
                Pack.shuffleCardPack(52);
            }

            if (intVal == 50)
            {   
                Pack.shuffleCardPack(53);
            }

            if (intVal == 51)
            {
                Pack.shuffleCardPack(54);
            }

            if (intVal > 51)
            {
                Console.WriteLine("The limit is 51 so these are 51 cards");

                Pack.shuffleCardPack(105);

            }

            // Depending on what the player's input is the different if statment will actiavte

            if (Pack.shuffleCardPack(2)) //checks the shufflecardpack method for the number 2 and calls it
            {
                Console.WriteLine("Riffle Shuffle works"); //write a message that the Riffle Shuffle works 
            }


            int intVall;

            string userInputt;

            Console.Write("How many Cards you want? (max51)"); //Asks the user how many Cards would he like from the riffle shuffle

            userInputt = Console.ReadLine();

            intVall = Convert.ToInt32(userInputt);

            if (intVall < 0)
            {
                Console.WriteLine("The minimum amount is 0");

            }
            if (intVall == 1)
            {
                Pack.shuffleCardPack(55);
            }   

            if (intVall == 2)
            {
                Pack.shuffleCardPack(56);
            }

            if (intVall == 3)
            {
                Pack.shuffleCardPack(57);
            }

            if (intVall == 4)
            {
                Pack.shuffleCardPack(58);
            }

            if (intVall == 5)
            {
                Pack.shuffleCardPack(59);
            }

            if (intVall == 6)
            {
                Pack.shuffleCardPack(60);
            }

            if (intVall == 7)
            {
                Pack.shuffleCardPack(61);
            }

            if (intVall == 8)
            {
                Pack.shuffleCardPack(62);
            }

            if (intVall == 9)
            {
                Pack.shuffleCardPack(63);
            }
            if (intVal == 10)
            {   
                Pack.shuffleCardPack(64);
            }
            if (intVal == 11)
            {
                Pack.shuffleCardPack(65);
            }

            if (intVal == 12)
            {
                Pack.shuffleCardPack(66);
            }

            if (intVal == 13)
            {
                Pack.shuffleCardPack(67);
            }

            if (intVal == 14)
            {
                Pack.shuffleCardPack(68);
            }

            if (intVal == 15)
            {
                Pack.shuffleCardPack(69);
            }

            if (intVal == 16)
            {
                Pack.shuffleCardPack(70);
            }

            if (intVal == 17)
            {
                Pack.shuffleCardPack(71);
            }   

            if (intVal == 18)
            {
                Pack.shuffleCardPack(72);
            }

            if (intVal == 19)
            {
                Pack.shuffleCardPack(73);
            }

            if (intVal == 20)
            {
                Pack.shuffleCardPack(74);
            }

            if (intVal == 21)
            {
                Pack.shuffleCardPack(75);
            }

            if (intVal == 22)
            {
                Pack.shuffleCardPack(76);
            }

            if (intVal == 23)
            {
                Pack.shuffleCardPack(77);
            }

            if (intVal == 24)
            {
                Pack.shuffleCardPack(78);
            }

            if (intVal == 25)
            {
                Pack.shuffleCardPack(79);
            }

            if (intVal == 26)
            {
                Pack.shuffleCardPack(80);
            }

            if (intVal == 27)
            {
                Pack.shuffleCardPack(81);
            }

            if (intVal == 28)
            {
                Pack.shuffleCardPack(82);
            }

            if (intVal == 29)
            {
                Pack.shuffleCardPack(83);
            }

            if (intVal == 30)
            {
                Pack.shuffleCardPack(84);
            }

            if (intVal == 31)
            {   
                Pack.shuffleCardPack(85);
            }

            if (intVal == 32)
            {
                Pack.shuffleCardPack(86);
            }

            if (intVal == 33)
            {
                Pack.shuffleCardPack(87);
            }

            if (intVal == 34)
            {
                Pack.shuffleCardPack(88);
            }

            if (intVal == 35)
            {
                Pack.shuffleCardPack(89);
            }

            if (intVal == 36)
            {
                Pack.shuffleCardPack(90);
            }

            if (intVal == 37)
            {
                Pack.shuffleCardPack(91);
            }

            if (intVal == 38)
            {
                Pack.shuffleCardPack(92);
            }

            if (intVal == 39)
            {
                Pack.shuffleCardPack(93);
            }

            if (intVal == 40)
            {
                Pack.shuffleCardPack(94);
            }
            if (intVal == 41)
            {
                Pack.shuffleCardPack(95);
            }

            if (intVal == 42)
            {
                Pack.shuffleCardPack(96);
            }

            if (intVal == 43)
            {
                Pack.shuffleCardPack(97);
            }

            if (intVal == 44)
            {
                Pack.shuffleCardPack(98);
            }

            if (intVal == 45)
            {
                Pack.shuffleCardPack(99);
            }

            if (intVal == 46)
            {
                Pack.shuffleCardPack(100);
            }

            if (intVal == 47)
            {
                Pack.shuffleCardPack(101);
            }

            if (intVal == 48)
            {
                Pack.shuffleCardPack(102);
            }

            if (intVal == 49)
            {
                Pack.shuffleCardPack(103);
            }

            if (intVal == 50)
            {
                Pack.shuffleCardPack(104);
            }

            if (intVall == 51)
            {
                Pack.shuffleCardPack(105);
            }

            if (intVall > 51)
            {
                Console.WriteLine("The limit is 51 so these are 51 cards");

                Pack.shuffleCardPack(105);

            }
            // Depending on what the player's input is the different if statment will actiavte

            if (intVall == 10)
            {
                Pack.shuffleCardPack(64);
            } // Depending on what the player's input is the different if statment will actiavte

            if (Pack.shuffleCardPack(3)) //checks the shufflecardpack method for the number 3 and calls it
            {
                Console.WriteLine("No Shuffle works"); //write a message that the No Shuffle works 
            }

        }
    }
}
