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

    }
}
