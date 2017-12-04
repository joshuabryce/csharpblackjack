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
            string hitOrStay = "";
            Console.WriteLine(GetCardDeck().GetnumLeft());
            if (GetCardDeck().GetnumLeft() < cardDeck.GetminPlayable())
            {
                cardDeck.shuffle();
            }
            
            playerHand.dealCard(cardDeck.drawCard(),true);
            dealerHand.dealCard(cardDeck.drawCard(),true);
            Console.Write("Your card: ");
            playerHand.printHand();
            Console.Write("Dealer's card: ");
            dealerHand.printHand();

            playerHandValue = playerHand.getValueOfHand();
            Console.WriteLine("Your total score: " + playerHandValue);
            while (playerHandValue < 21 && hitOrStay!="stay")
            {

               
                Console.WriteLine("do you want to hit or stay? (Type 'hit' or 'stay')");
                hitOrStay=Console.ReadLine().ToLower();
                if (hitOrStay == "hit")
                {
                    playerHand.dealCard(cardDeck.drawCard(), true);
                }

                playerHandValue = playerHand.getValueOfHand();
                Console.WriteLine("Your total score: "+playerHandValue);
                Console.WriteLine("Your hand:");
                playerHand.printHand();
                Console.WriteLine();
            }
            if (playerHandValue > 21)
            {
                Console.WriteLine("busted!");
                
            }
            else if (playerHandValue == 21)
            {
                Console.WriteLine("player wins!");
            }
            else
            {
                while (dealerHand.getValueOfHand() < 17)
                {
                    dealerHand.dealCard(cardDeck.drawCard(), true);
                    
                }
                Console.WriteLine();
                Console.WriteLine("Dealer's value :"+ dealerHand.getValueOfHand()); 
                Console.WriteLine("Dealer's hand:");
                dealerHand.printHand();
                if (dealerHand.getValueOfHand() > 21)
                {
                    Console.WriteLine();
                    Console.WriteLine("Player wins!");

                }
                else if (playerHand.getValueOfHand()==dealerHand.getValueOfHand())
                {
                    Console.WriteLine("Tie!");
                }
            }
            //cardDeck.printDeck();
            //Console.ReadLine();
            restart();
        }

        public void restart()
        {
            playerHand.clearHand();
            dealerHand.clearHand();
        }
    }
}
