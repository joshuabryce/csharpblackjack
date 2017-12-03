using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{

    class CardDeck
    {

        private Stack<Card> deck; //!< Member variable "*deck"
        private int numLeft; //!< Member variable "numLeft"
        private int shuffleAt; //!< Member variable "shuffleAt"
        private int minPlayable; //!< Member variable "minPlayable"

        public Stack<Card> Getdeck() { return deck; }
        public void Setdeck(Stack<Card> deck) { this.deck = deck; }
        public int GetnumLeft() { return numLeft=deck.Count; }
        public void SetnumLeft(int val) { numLeft = val; }
        public int GetshuffleAt() { return shuffleAt; }

        public void SetshuffleAt(int val) { shuffleAt = val; }

        public int GetminPlayable() { return minPlayable; }

        public void SetminPlayable(int val) { minPlayable = val; }

        public CardDeck()
        {
            deck = new Stack<Card>();
            //ctor
            //List<Card> deck = new List<Card>();
            //52 cards
            //4 suits
            //13 cards

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {

                    Card card = new Card((Suit)i, (Rank)j, j, j, false);

                    deck.Push(card);
                    //Console.Write(i+" ");
                    //Console.WriteLine(card.GetSuit() + " " + card.GetRank());

                }
            }

            int numLeft = 0; //!< Member variable "numLeft"
            int shuffleAt = 15; //!< Member variable "shuffleAt"
            int minPlayable = 0; //!< Member variable "minPlayable"
        }


        public void shuffle()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            deck =new Stack<Card>(deck.OrderBy(x => rnd.Next()));
            
        }

        public Card drawCard() { return deck.Pop(); }

        public void printDeck()
        {
            Card[] copyDeck = new Card[deck.Count];
            deck.CopyTo(copyDeck,0);
            
            /*
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {                   
                    Console.Write(i + " ");
                    Console.WriteLine(copyDeck[count].GetSuit() + " " + copyDeck[count].GetRank());
                    count++;
                }
            }
            */
            for(int i=0; i< deck.Count; i++)
            {
                Console.WriteLine(i + " "+copyDeck[i].GetSuit() + " " + copyDeck[i].GetRank());
            }
        }
    }
}
