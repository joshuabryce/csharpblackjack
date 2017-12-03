using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class GameInterface
    {
        public void ShowTitle()
        {
            Console.WriteLine("██████╗ ██╗      █████╗  ██████╗██╗  ██╗     ██╗ █████╗  ██████╗██╗  ██╗");
            Console.WriteLine("██╔══██╗██║     ██╔══██╗██╔════╝██║ ██╔╝     ██║██╔══██╗██╔════╝██║ ██╔╝");
            Console.WriteLine("██████╔╝██║     ███████║██║     █████╔╝      ██║███████║██║     █████╔╝ ");
            Console.WriteLine("██╔══██╗██║     ██╔══██║██║     ██╔═██╗ ██   ██║██╔══██║██║     ██╔═██╗ ");
            Console.WriteLine("██████╔╝███████╗██║  ██║╚██████╗██║  ██╗╚█████╔╝██║  ██║╚██████╗██║  ██╗");
            Console.WriteLine("╚═════╝ ╚══════╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝ ╚════╝ ╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝");
        }

        public void DisplayMenu()
        {
            Console.WriteLine("\n\nPlease choose from the options below\n\n");
            Console.WriteLine("1) Play New Game");
            Console.WriteLine("2) Instructions");
            Console.WriteLine("3) Quit Game");
        }

        public void ShowInstructions()
        {
            Console.WriteLine("The Object of the Game\n");
            Console.WriteLine("To beat the dealer's hand without exceeding a count of 21");
            Console.WriteLine("in order to win as much money from the dealer (the casino)");
            Console.WriteLine("as you can.");
        }

        public void ShowBoard(/*some varibles should be added here to properly show board*/)
        {

        }

    }
}
