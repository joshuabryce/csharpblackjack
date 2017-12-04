using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class PlayerStats
    {
        private string playerID;
        private double balance;

        public string PID { get; set; } // player ID
        public int PlayerMoney { get; set; } // how much money they have in the bank

        public PlayerStats()
        {
            //empty constructor
        }
        public PlayerStats(string playerIdentification, int moneyAmt)
        {
            PID = playerIdentification;
            PlayerMoney = moneyAmt;
        }

        public override string ToString()
        {
            return String.Format("{0} has {1} total left in chips", PID, PlayerMoney);
        }

    }
}