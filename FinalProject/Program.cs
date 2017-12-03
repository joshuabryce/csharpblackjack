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
            GameInterface draw = new GameInterface();
            int menuchoice = 0;
            bool inMenu = true;

            draw.ShowTitle();
            do
            {
                try
                {
                    draw.DisplayMenu();
                    menuchoice = Int32.Parse(Console.ReadLine());

                    //executing the menu
                    switch (menuchoice)
                    {
                        case 1:
                            //PlayGame();
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
                catch (Exception)
                {
                    Console.WriteLine("input needs to be an integer number");
                }


            } while (inMenu);

            Console.ReadLine();
            /*CardDeck deck = new CardDeck();
            //Console.ReadLine();

            deck.shuffle();
            deck.printDeck();*/

            BlackJack blackJack = new BlackJack();
            
            Console.ReadLine();
        }
    }
}
