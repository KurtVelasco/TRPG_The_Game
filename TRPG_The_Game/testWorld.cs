using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TRPG_The_Game.characterCreation;

namespace TRPG_The_Game
{
    internal class testWorld
    {
        characterCreation mainCharacter {  get; set; }
        public Dictionary<CharacterStat, int> CharacterStats { get; set; }



        public testWorld(characterCreation player)
        {
            mainCharacter = player; 
        }
        public void announceMC()
        {
            Console.WriteLine("character: " + mainCharacter.lastName + " " + mainCharacter.firstName + " has joined");
        }
        public void getPlayerstats()
        {
        }
        public void dealPhysicalDamageTest(int rawDamage)
        {
            int currentHP = mainCharacter.CharacterStatsDicts[CharacterStat.Health];
            Random random = new Random();
            int minimumDamageThreshold = random.Next(1, rawDamage + 1);

            int damageAfterDefense = rawDamage - mainCharacter.CharacterStatsDicts[CharacterStat.PhysicalDefense];
            int finalDamage = Math.Max(damageAfterDefense, minimumDamageThreshold);
            currentHP -= finalDamage;
            currentHP = characterTalents.afterDamage(currentHP, mainCharacter);
         
            if (mainCharacter.CharacterStatsDicts[CharacterStat.Health] <= 0)
            {
                mainCharacter.CharacterStatsDicts[CharacterStat.Health] = 0;
            }
                
        }
    }
}
