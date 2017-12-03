using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class BlackJack
    {
        private CardDeck cardDeck;
        private PlayerHand playerHand;
        private DealerHand dealerHand;

        public BlackJack()
        {
            cardDeck = new CardDeck();
            playerHand = new PlayerHand();
            dealerHand = new DealerHand();
            cardDeck.shuffle();
            //Play();
        }

        internal CardDeck GetCardDeck()
        {
            return cardDeck;
        }

        internal void SetCardDeck(CardDeck value)
        {
            cardDeck = value;
        }

        public void Play()
        {
            int playerHandValue = 0;
            Console.WriteLine(GetCardDeck().GetnumLeft());
            if (GetCardDeck().GetnumLeft() < cardDeck.GetminPlayable())
            {
                cardDeck.shuffle();
            }
            
            playerHand.dealCard(cardDeck.drawCard(),true);
            dealerHand.dealCard(cardDeck.drawCard(),true);
            playerHand.printHand();
            dealerHand.printHand();

            playerHandValue = playerHand.getValueOfHand();
            Console.WriteLine(playerHandValue);
            while (playerHandValue < 21)
            {

               
                Console.WriteLine("do you want to hit or stay?");
                if (Console.ReadLine().ToLower() == "hit")
                {
                    playerHand.dealCard(cardDeck.drawCard(), true);
                }

                playerHandValue = playerHand.getValueOfHand();
                Console.WriteLine(playerHandValue);
            }
            if (playerHandValue > 21)
            {
                Console.WriteLine("busted!");
            }
            
            //cardDeck.printDeck();
            Console.ReadLine();
        }

    }
}
