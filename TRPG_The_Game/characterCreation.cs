using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG_The_Game
{
    public class characterCreation
    {
        public enum CharacterStat
        {
            Health,
            SkillPoints,
            PhysicalAttack,
            MagicAttack,
            PhysicalDefense,
            MagicResistance,
            Speed
        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Class {  get; set; }
        public char Gender {  get; set; }
        public List<string> Traits { get; set; }
        public Dictionary<CharacterStat, int> CharacterStatsDicts { get; set; }
        public bool activeBrave = true;

        public void inputName()
        {
            Console.Write("Input your character first name: ");
            firstName = Console.ReadLine();

            Console.Write("Input your character last name: ");
            lastName = Console.ReadLine();
            inputGender();  
        }
        public void inputGender()
        {
            Console.Write("Input your gender (Female/Male): ");
            switch (Console.ReadLine().ToLower()) 
            {
                case "male":
                    Gender = 'M';
                    inputClass();
                    break;
                case "female":
                    Gender = 'F';
                    inputClass();
                    break;
                default:
                    inputGender();
                    break;
            }

        }
     
        public void inputClass()
        {
            CharacterStatsDicts = new Dictionary<CharacterStat, int>();
            Traits = new List<string>();    
        // Assigning values to stats
            
            // 0 Health
            // 1 Skill Points
            // 2 physical attac
            // 3 magic attac
            // 4 physic def
            // 5 magic resist
            // 6 speed
            Console.Write("Input your gender (Warrior | Black Mage | Archer : ");
            switch (Class = Console.ReadLine().ToLower())
            {
                case "warrior":
                    CharacterStatsDicts[CharacterStat.Health] = 120;
                    CharacterStatsDicts[CharacterStat.SkillPoints] = 50;
                    CharacterStatsDicts[CharacterStat.PhysicalAttack] = 40;
                    CharacterStatsDicts[CharacterStat.MagicAttack] = 10;
                    CharacterStatsDicts[CharacterStat.PhysicalDefense] = 40;
                    CharacterStatsDicts[CharacterStat.MagicResistance] = 10;
                    CharacterStatsDicts[CharacterStat.Speed] = 7;
                    Traits.Add("Brave");
                    break;
                case "black mage":
                    CharacterStatsDicts[CharacterStat.Health] = 80;
                    CharacterStatsDicts[CharacterStat.SkillPoints] = 100;
                    CharacterStatsDicts[CharacterStat.PhysicalAttack] = 20;
                    CharacterStatsDicts[CharacterStat.MagicAttack] = 50;
                    CharacterStatsDicts[CharacterStat.PhysicalDefense] = 20;
                    CharacterStatsDicts[CharacterStat.MagicResistance] = 30;
                    CharacterStatsDicts[CharacterStat.Speed] = 5;
                    Traits.Add("Brave");
                    break;
                case "archer":
                    CharacterStatsDicts[CharacterStat.Health] = 90;
                    CharacterStatsDicts[CharacterStat.SkillPoints] = 70;
                    CharacterStatsDicts[CharacterStat.PhysicalAttack] = 40;
                    CharacterStatsDicts[CharacterStat.MagicAttack] = 40;
                    CharacterStatsDicts[CharacterStat.PhysicalDefense] = 20;
                    CharacterStatsDicts[CharacterStat.MagicResistance] = 15;
                    CharacterStatsDicts[CharacterStat.Speed] = 9;
                    Traits.Add("Brave");
                    break;
                default:
                    inputClass();
                break;
               
            }
        }
    }
}
