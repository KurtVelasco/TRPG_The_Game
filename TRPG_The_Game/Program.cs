using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPG_The_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            characterCreation player = new characterCreation();
            player.inputName();
            testWorld world1 = new testWorld(player);
            world1.announceMC();
            Console.ReadLine();
            world1.dealPhysicalDamageTest(200);

        }
    }
}
