/// Final Project
/// 
/// @author: Josh Bryce
/// 
///
/// Problem Statement: A game of blackjack
/// 
/// 
/// Overall Plan:
/// 1) Use object oriented design to represent a game of blackjack
/// 2) use classes such as the following: 
/// card, carddeck, playerhand, a game of blackjack and etc. to represent the game
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BlackJack blackJack = new BlackJack();
            GameInterface draw = new GameInterface();
            int menuchoice = 0;
            bool inMenu = true;

            draw.ShowTitle();
            do
            {
                //try
                //{
                draw.DisplayMenu();
                bool result = Int32.TryParse(Console.ReadLine(), out menuchoice);
                if (result) { 

                    //executing the menu
                    switch (menuchoice)
                    {
                        case 1:
                            blackJack.Play();
                            break;
                        case 2:
                            draw.ShowInstructions();
                            inMenu = true;
                            break;
                        case 3:
                            Console.WriteLine("Goodbye");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid menu choice");
                            break;
                    }

                }
                //catch (Exception)
                else //using an all inclusive try catch block is not a best practice, ALL exceptions will fall here and it makes it hard to debug
                {
                    Console.WriteLine("Please enter in a valid input choice from 1 to 3");
                }


            } while (inMenu);

            Console.ReadLine();
            /*CardDeck deck = new CardDeck();
            //Console.ReadLine();

            deck.shuffle();
            deck.printDeck();*/

            
            
            Console.ReadLine();
        }
    }
}
