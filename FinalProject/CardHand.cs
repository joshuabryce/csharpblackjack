using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class CardHand
    {
        private Stack<Card> cards;

        public void clearHand()
        {
            cards = new Stack<Card>();
        }

        public int dealCard(Card card, bool isVisible)
        {
            //cards.Push
            //return cards.Pop();
            //int??? why does it return an int???
            return 1;

        }
        public string[] getHandForDisplay()
        {
            return printHand(cards);
        }

        public String[] printHand(Stack<Card> deck)
        {
            Card[] copyDeck = new Card[deck.Count];
            String[] stringDeck = new String[deck.Count];
            deck.CopyTo(copyDeck, 0);
            for(int i=0; i< deck.Count; i++)
            {
                stringDeck[i] = copyDeck[i].GetSuit() + " " + copyDeck[i].GetRank();
            }

            
            return stringDeck;
        }
    }
}
