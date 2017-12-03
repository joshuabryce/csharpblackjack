using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{

    public enum Suit { clubs, diamonds, hearts, spades }; //!< Member variable "{clubs,diamonds,hearts,spades}"
    public enum Rank { ace, two, three, four, five, six, seven, eight, nine, ten, jack, queen, king }; //!< Member variable "{ace,1,2,3,4,5,6,7,8,9,10,jack,queen,king}"

    class Card
    {


            

        private int valuePrimary; //!< Member variable "valuePrimary"
        private int valueSecondary; //!< Member variable "valueSecondary"
        private bool isVisible; //!< Member variable "isVisible"


        private Suit suit;
        private Rank rank;

        /** Access {clubs,diamonds,hearts,spades}
            * \return The current value of {clubs,diamonds,hearts,spades}
            */
        public Suit GetSuit() { return suit; }
        /** Set {clubs,diamonds,hearts,spades}
            * \param val New value to set
            */
        public void SetSuit(Suit suit) { this.suit = suit; }
        /** Access {ace,1,2,3,4,5,6,7,8,9,10,jack,queen,king}
            * \return The current value of {ace,1,2,3,4,5,6,7,8,9,10,jack,queen,king}
            */
        public Rank GetRank() { return rank; }
        public void SetRank(Rank rank) { this.rank = rank; }
        public int GetvaluePrimary() { return valuePrimary; }
        /** Set valuePrimary
            * \param val New value to set
            */
        public void SetvaluePrimary(int val) { valuePrimary = val; }
        /** Access valueSecondary
            * \return The current value of valueSecondary
            */
        public int GetvalueSecondary() { return valueSecondary; }
        /** Set valueSecondary
            * \param val New value to set
            */
        public void SetvalueSecondary(int val) { valueSecondary = val; }
        /** Access isVisible
            * \return The current value of isVisible
            */
        public bool GetisVisible() { return isVisible; }
        /** Set isVisible
            * \param val New value to set
            */
        public void SetisVisible(bool val) { isVisible = val; }



        public Card(Suit suit, Rank rank, int valuePrimary, int valueSecondary, bool isVisible)
        {
             this.suit= suit;
              this.rank= rank;
               this.valuePrimary= valuePrimary;
                this.valueSecondary= valueSecondary;
                 this.isVisible= isVisible;
            //ctor
        }


    }
}
