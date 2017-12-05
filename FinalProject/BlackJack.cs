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
        private int betAmt;
        private int playerCash;
        //private int roundNumber = 0; //internal tracking 
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

            SetPlayerCashOnHand(100); //Mr Money Bags is giving the player 100 bucks!
            
            int playerMoney = GetPlayerCashOnHand();
            int chipWager = 0, totalWager = 0;
            bool keepPlaying = true, goodwager = true;

            while (keepPlaying)
            {
                if (GetCardDeck().GetnumLeft() < cardDeck.GetshuffleAt())
                {
                    //cardDeck.shuffle();
                    CardDeck newDeck = new CardDeck();
                    cardDeck = newDeck;
                }


                int playerHandValue = 0;
                string hitOrStay = "";
                string yORn = " ";
                Console.WriteLine(GetCardDeck().GetnumLeft());


                playerHand.dealCard(cardDeck.drawCard(), true);
                dealerHand.dealCard(cardDeck.drawCard(), true);
                Console.WriteLine("You currently have $" + playerMoney);

                do
                {
                    Console.WriteLine("How many chips are you willing to wager? (1 chip = $5)");

                    chipWager = Int32.Parse(Console.ReadLine());
                    if (chipWager < 1)
                    {
                        Console.WriteLine("You must wager at least 1 chip ($5) to play a hand");
                        Console.WriteLine("Automatically setting wager to 1 chip ($5)");
                        chipWager = 1;
                    }
                    SetBetAmt(chipWager);

                    totalWager = GetBetAmt();
                    if (totalWager > playerMoney)
                    {
                        goodwager = false;
                        Console.WriteLine("The total was $" + totalWager + " and you don't have that much!");
                    }
                    else
                    {
                        goodwager = true;
                        Console.WriteLine("You have wagered $" + totalWager);
                        Console.ReadKey();
                    }
                } while (!goodwager);


                Console.Write("Your card: ");
                playerHand.printHand();
                Console.Write("Dealer's card: ");
                dealerHand.printHand();

                //roundNumber = 1; //internal tracking

                playerHandValue = playerHand.getValueOfHand();
                Console.WriteLine("Your total score: " + playerHandValue);
                Console.ReadKey();
                while (playerHandValue < 21 && hitOrStay != "stay")
                {


                    Console.WriteLine("do you want to hit or stay? (Type 'hit' or 'stay')");
                    hitOrStay = Console.ReadLine().ToLower();
                    if (hitOrStay == "hit")
                    {
                        playerHand.dealCard(cardDeck.drawCard(), true);
                    }

                    playerHandValue = playerHand.getValueOfHand();
                    Console.WriteLine("Your total score: " + playerHandValue);
                    Console.WriteLine("Your hand:");
                    playerHand.printHand();
                    Console.WriteLine();
                }
                if (playerHandValue > 21)
                {
                    Console.WriteLine("busted!");
                    playerMoney -= totalWager;
                    dealerWins();
                }
                else if (playerHandValue == 21)
                {
                    playerWins();
                    playerMoney += totalWager;
                }
                else
                {
                    while (dealerHand.getValueOfHand() < 17)
                    {
                        dealerHand.dealCard(cardDeck.drawCard(), true);

                    }
                    Console.WriteLine();
                    Console.WriteLine("Dealer's value :" + dealerHand.getValueOfHand());
                    Console.WriteLine("Dealer's hand:");
                    dealerHand.printHand();
                    if (dealerHand.getValueOfHand() > 21)
                    {
                        playerWins();
                        playerMoney += totalWager;
                    }
                    else if (playerHand.getValueOfHand() == dealerHand.getValueOfHand())
                    {
                        tie();

                    }
                }

                if(playerMoney < 5)
                {
                    keepPlaying = false;
                }

                Console.WriteLine("Would you like to player another round? (Type 'y' or 'n')");
                yORn = Console.ReadLine().ToLower();
                if (yORn[0] == 'n')
                {
                    break;
                }
                //cardDeck.printDeck();
                //Console.ReadLine();
                restart();
            }
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

        public void SetPlayerCashOnHand(int pCash)
        {
            playerCash = pCash;
        }
        public int GetPlayerCashOnHand()
        {
            return playerCash;
        }

        public int GetBetAmt()
        {
            return betAmt;
        }

    }
}
