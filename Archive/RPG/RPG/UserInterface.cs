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
        private static PlayerClassList ClassList;
        private static GameMap Map;
        private static Player Player;
        
        public static void Initialize()
        {
            ClassList = new PlayerClassList();
            Map = new GameMap();

            ClassList.CreateClassList();
        }

        public static void CreatePlayer()
        {
            Print.Slow("Please enter your ", 1);
            Print.Slow("name", 1, "DarkGreen");

            Print.SlowLine("");
            string playerName = Console.ReadLine();

            
            string playerClass = "";
            while (String.IsNullOrWhiteSpace(playerClass))
            {
                Console.Clear();
                Print.SlowLine("Please enter your desired class...");
                ClassList.PrintList();
                Print.Slow("");
                playerClass = Console.ReadLine();

                if (ClassList.Find(playerClass) == null)
                    playerClass = null;
            }

            Print.SlowLine("");

            if (playerName.ToUpper().Equals("CHRONO"))
                Player = new Player(playerName, 10000, 20000, 1000000, 50000, ClassList.Find(playerClass));
            else
                Player = new Player(playerName, 100, 20, 10, 5, ClassList.Find(playerClass));

            Console.Clear();
            Print.Slow("Greetings, ");
            Print.SlowLine(Player.Name, 0, "blue");
            Print.Slow("Your class is ");
            Print.SlowLine(Player.PlayerClass.Name, 0, Player.PlayerClass.ClassColour);
            Print.SlowLine(Player.PlayerClass.Description);

            Player.PrintStats();

            Console.ReadLine();
        }

        public static void AddToInventory()
        {
            Console.WriteLine("Add something to inventory...");
            string playerItemStr = Console.ReadLine();
            int playerItemInt = 0;
            if(int.TryParse(playerItemStr, out playerItemInt))
                Player.Add(playerItemInt);
        }

        public static void MainLoop()
        {
            string playerInput = "";
            while (Player.Health > 0 || !playerInput.ToUpper().Equals("EXIT"))
            {
                playerInput = Console.ReadLine();

                if (playerInput.ToUpper().Equals("EXIT"))
                {
                    Console.WriteLine("Goodbye...");
                    Program.Exit();
                }

                switch (playerInput.ToUpper())
                {
                    case "DEBUG":
                        System.Diagnostics.Debugger.Break();

                        Console.ReadLine();
                        break;

                    case "MOVE":
                        Map.PrintMap();
                        break;
                        
                }
            } //End of while loop
        }
    }
}
