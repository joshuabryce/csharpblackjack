using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class GameStats 
    {
        private List<PlayerStats> playerStats ; //a list of player stats

        private void LoadPlayerStats(string pid, double chips)
        {
            playerStats.Add(new PlayerStats(pid, chips));
        }

        private void SavePlayerStats()
        {
            // save something
        }

        public void ClearPlayerStats(List<PlayerStats> deck)
        {
            playerStats.Clear();
        }

    }
}
