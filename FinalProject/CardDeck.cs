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




        /** Access *deck
         * \return The current value of *deck
         */
        public Stack<Card> Getdeck() { return deck; }
        /** Set *deck
         * \param val New value to set
         */
        public void Setdeck(Stack<Card> deck) { this.deck = deck; }
        /** Access numLeft
         * \return The current value of numLeft
         */
        public int GetnumLeft() { return numLeft; }
        /** Set numLeft
         * \param val New value to set
         */
        public void SetnumLeft(int val) { numLeft = val; }
        /** Access shuffleAt
         * \return The current value of shuffleAt
         */
        public int GetshuffleAt() { return shuffleAt; }
        /** Set shuffleAt
         * \param val New value to set
         */
        public void SetshuffleAt(int val) { shuffleAt = val; }
        /** Access minPlayable
         * \return The current value of minPlayable
         */
        public int GetminPlayable() { return minPlayable; }
        /** Set minPlayable
         * \param val New value to set
         */
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
            Card[] copyDeck = new Card[52];
            deck.CopyTo(copyDeck,0);
            

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
        }
    }
}
