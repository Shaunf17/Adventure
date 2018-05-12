using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Adventure;

namespace Adventure
{
    class Program
    {
        Player PlayerCharacter;
        Goblin goblin;

        public Program()
        {
            //PlayerCharacter = new Player();
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            p.StartGame();

            Console.ReadLine();
        }

        public void StartGame()
        {
            //Console.ForegroundColor = ConsoleColor.Cyan;
            SetTextColour("cyan");
            Console.WriteLine("Welcome, Adventurer...");

            SetTextColour("white");
            Console.Write("Please name your character: ");

            PlayerCharacter = new Player(Console.ReadLine());

            Console.WriteLine("Welcome, " + PlayerCharacter.Name);

            CombatLauncher();
        }

        public void CombatLauncher()
        {
            goblin = new Goblin();

            Console.Write("You come across a ");
            SetTextColour("red");
            Console.WriteLine(goblin.Name);

            while (goblin.Health > 0)
            {
                SetTextColour("white");
                Console.WriteLine("What do you do?");

                string combatInput = Console.ReadLine();

                switch (combatInput)
                {
                    case "attack":
                        Attack("goblin");
                        break;
                    case "run":
                        Run();
                        break;
                }

                Console.WriteLine(string.Format("You hit for {0}", PlayerCharacter.AttackPower));
                Console.WriteLine(string.Format("Goblin Health {0}", goblin.Health));

                Attack("player");
                Console.WriteLine(string.Format("{0} hits for {1}", goblin.Name, goblin.AttackPower));
                Console.WriteLine(string.Format("Your Health: {0}", PlayerCharacter.Health));
            }

            Console.WriteLine(string.Format("{0} Defeated!", goblin.Name));
        }

        public void Attack(string target)
        {
            switch (target)
            {
                case "goblin":
                    goblin.Health -= (PlayerCharacter.AttackPower - (1 * goblin.DefencePower));
                    break;

                case "player":
                    PlayerCharacter.Health -= (goblin.AttackPower - (1 * PlayerCharacter.DefencePower));
                    break;
            }
        }

        public void Run()
        { }

        /// <summary>
        /// <para>Sets the console output text colour. The colour is only changed once the method is re-called</para>
        /// </summary>
        /// <param name="colour"></param>
        public static void SetTextColour(string colour)
        {
            switch (colour)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "black":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
            }
        }
    }
}