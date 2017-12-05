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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("██████╗ ██╗      █████╗  ██████╗██╗  ██╗     ██╗ █████╗  ██████╗██╗  ██╗");
            Console.WriteLine("██╔══██╗██║     ██╔══██╗██╔════╝██║ ██╔╝     ██║██╔══██╗██╔════╝██║ ██╔╝");
            Console.WriteLine("██████╔╝██║     ███████║██║     █████╔╝      ██║███████║██║     █████╔╝ ");
            Console.WriteLine("██╔══██╗██║     ██╔══██║██║     ██╔═██╗ ██   ██║██╔══██║██║     ██╔═██╗ ");
            Console.WriteLine("██████╔╝███████╗██║  ██║╚██████╗██║  ██╗╚█████╔╝██║  ██║╚██████╗██║  ██╗");
            Console.WriteLine("╚═════╝ ╚══════╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝ ╚════╝ ╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝");
            Console.ResetColor();
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
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("The Object of the Game\n");
            Console.WriteLine("The first basic rule of blackjack is simple: " +
                              "\nbeat the dealer’s hand without going over 21");
            Console.WriteLine("Each round, the dealer deals each card to the player");
            Console.WriteLine("Based on the card the player is dealt, the player");
            Console.WriteLine("will then decide whether or not they want to ");
            Console.WriteLine("have another card dealt to them.");
            Console.WriteLine("If the player wants an additional card");
            Console.WriteLine("he/she will announce 'hit me', otherwise");
            Console.WriteLine("they will announce 'stay'.");
            Console.WriteLine("If the player goes over 21, the player loses.");
            Console.WriteLine("Likewise if the dealer goes over 21, the dealer loses.");
            Console.WriteLine("The first player to reach 21 wins the round,");
            Console.WriteLine("if both the dealer and the player have under 21, then");
            Console.WriteLine("the person with the higher number wins the round.");
            Console.ResetColor();
        }

        public void ShowBoard(/*some varibles should be added here to properly show board*/)
        {

        }

    }
}
