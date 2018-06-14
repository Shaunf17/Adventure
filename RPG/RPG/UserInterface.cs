using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Characters;
using RPG.Inventory;
using RPG.Items;
using RPG.Map;
using RPG.Utilities;

namespace RPG
{
    public static class UserInterface
    {
        public static void CreatePlayer()
        {
            Print.Slow("Please enter your ", 1);
            Print.Slow("name", 1, "DarkGreen");
            Console.WriteLine();

            string playerName = Console.ReadLine();

            Warrior w = new Warrior();
            Rogue r = new Rogue();
            Mage m = new Mage();

            Player player = new Player(playerName, 100, 20, 10, 5, m);

            Print.Slow("The Player's class is ");
            Print.Slow(player.PlayerClass.Name, 0, "Red");

            Console.ReadLine();
        }
    }
}
