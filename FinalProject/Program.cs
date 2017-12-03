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
            CardDeck deck = new CardDeck();
            //Console.ReadLine();

            deck.shuffle();
            deck.printDeck();
            Console.ReadLine();
        }
    }
}
