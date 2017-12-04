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

        public CardHand()
        {
            cards = new Stack<Card>();
        }

        public void clearHand()
        {
            cards = new Stack<Card>();
        }

        public int dealCard(Card card, bool isVisible)
        {
            //cards.Push
            //return cards.Pop();
            //int??? why does it return an int???
            card.SetisVisible(isVisible);
            cards.Push(card);
            return 1;

        }
        public string[] getHandForDisplay()
        {
            return returnStringHand(cards);
        }

        public String[] returnStringHand(Stack<Card> deck)
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

        public void printHand()
        {
            Card[] copyDeck = new Card[cards.Count];
            String[] stringDeck = new String[cards.Count];
            cards.CopyTo(copyDeck, 0);
            for (int i = 0; i < cards.Count; i++)
            {
                Console.WriteLine(copyDeck[i].GetSuit() + " " + copyDeck[i].GetRank());
            }

        }

        public int getValueOfHand()
        {
            int value = 0;
            int currentCard = 0;
            bool firstAce = false;
            Card[] copyDeck = new Card[cards.Count];
            String[] stringDeck = new String[cards.Count];
            cards.CopyTo(copyDeck, 0);
            for (int i = 0; i < cards.Count; i++)
            {
                if ((int)copyDeck[i].GetRank() == 0 && !firstAce)
                {
                    firstAce = true;
                    currentCard = 11;
                }
                else if((int)copyDeck[i].GetRank()>=9)
                {
                    currentCard = 10;
                }
                else if((int)copyDeck[i].GetRank() >0)
                {
                    currentCard = (int)copyDeck[i].GetRank() + 1;
                }
                else
                {
                    currentCard = 1;
                }
                

                value +=currentCard;
                
            }
            if (value > 21 && firstAce)
            {
                value -= 10;
            }
            return value;
        }
    }
}
