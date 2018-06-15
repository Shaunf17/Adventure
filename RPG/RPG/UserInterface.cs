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
        private static PlayerClassList lst = new PlayerClassList();
        private static Player player;
        
        public static void Initialize()
        {
            lst.CreateClassList();
        }

        public static void CreatePlayer()
        {
            Print.Slow("Please enter your ", 1);
            Print.Slow("name", 1, "DarkGreen");

            Print.SlowLine("");
            string playerName = Console.ReadLine();

            Print.SlowLine("Please enter your desired class...");
            string playerClass = Console.ReadLine();

            if (playerName.ToUpper().Equals("JESUS"))
                player = new Player(playerName, 10000, 20000, 1000000, 50000, lst.Find(playerClass));
            else
                player = new Player(playerName, 100, 20, 10, 5, lst.Find(playerClass));

            Print.Slow("Greetings, ");
            Print.SlowLine(player.Name, 0, "blue");
            Print.Slow("Your class is ");
            Print.SlowLine(player.PlayerClass.Name, 0, player.PlayerClass.ClassColour);
            Print.SlowLine(player.PlayerClass.Description);

            player.PrintStats();

            Console.ReadLine();
        }
    }
}
