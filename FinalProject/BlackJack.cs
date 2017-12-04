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
            Play();
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
            Console.WriteLine(GetCardDeck().GetnumLeft());
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
