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
        private double betAmt;

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
            if (GetCardDeck().GetnumLeft() < cardDeck.GetshuffleAt())
            {
                //cardDeck.shuffle();
                CardDeck newDeck = new CardDeck();
                cardDeck = newDeck;
            }

            int playerHandValue = 0;
            string hitOrStay = "";
            Console.WriteLine(GetCardDeck().GetnumLeft());
            
            
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
                dealerWins();
            }
            else if (playerHandValue == 21)
            {
                playerWins();
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

                    playerWins();
                }
                else if (playerHand.getValueOfHand()==dealerHand.getValueOfHand())
                {
                    tie();
                    
                }
            }
            //cardDeck.printDeck();
            //Console.ReadLine();
            restart();
        }

        public void playerWins()
        {
            Console.WriteLine();
            Console.WriteLine("Player wins!");
        }

        public void dealerWins()
        {
            Console.WriteLine();
            Console.WriteLine("Dealer wins!");
        }

        public void tie()
        {
            Console.WriteLine("Tie!");
        }

        public void restart()
        {
            playerHand.clearHand();
            dealerHand.clearHand();
        }
        public void SetBetAmt(int chips)
        {
            //Console.WriteLine("How many chips to throw in?");
            // each chip is worth 5 bucks
            betAmt = chips * 5;
        }

        public double GetBetAmt()
        {
            return betAmt;
        }

    }
}
