using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG_The_Game
{
    public class characterTalents
    {
        characterTalents(string type)
        {
 
        }
        public static int afterDamage(int playerHealth, characterCreation currentPlayer)
        {
            foreach (string item in currentPlayer.Traits)
            {
                switch (item.ToLower())
                {
                    case "brave":
                        if(playerHealth <= 0 && currentPlayer.activeBrave) {
                            playerHealth = 1; 
                            currentPlayer.activeBrave = false;
                            break;
                        }
                        playerHealth = 1;
                        break;
                }
            }
            return playerHealth;
        }
    }
}
