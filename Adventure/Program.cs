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

        static Program program;
        CombatLauncher combat;
        

        public Program()
        {
            program = new Program();
            combat = new CombatLauncher();
        }

        static void Main(string[] args)
        {
            program.StartGame();
            Console.ReadLine();
        }

        public void StartGame()
        {
            SetTextColour("cyan");
            Console.WriteLine("Welcome, Adventurer...");

            SetTextColour("white");
            Console.Write("Please name your character: ");

            PlayerCharacter = new Player(Console.ReadLine());

            Console.WriteLine("Welcome, " + PlayerCharacter.Name);

            combat.Combat(InitializeEnemy(), PlayerCharacter);
        }

        public Character InitializeEnemy()
        {
            Goblin goblin = new Goblin();

            return goblin;
        }

        //public void CombatLauncher()
        //{
        //    goblin = new Goblin();

        //    Console.Write("You come across a ");
        //    SetTextColour("red");
        //    Console.WriteLine(goblin.Name);

        //    while (goblin.Health > 0)
        //    {
        //        SetTextColour("white");
        //        Console.WriteLine("What do you do?");

        //        string combatInput = Console.ReadLine();

        //        switch (combatInput)
        //        {
        //            case "attack":
        //                CombatLog(PlayerCharacter, PlayerCharacter.NormalAttack(), goblin);
        //                break;
        //            case "run":
        //                Run();
        //                break;
        //        }
        //        Console.WriteLine("");
        //        CombatLog(goblin, 5, PlayerCharacter);
        //    }

        //    Console.WriteLine(string.Format("{0} Defeated!", goblin.Name));
        //}

        //public void CombatLog(Character name, int damage, Character target)
        //{
        //    target.Health -= damage; 

        //    Console.WriteLine("{0} hit {1} for {2} damage!", name.Name, target.Name, damage);
        //    Console.WriteLine("{0} health: {1}", target.Name, target.Health);
        //}


        //public void Attack(string target)
        //{
        //    switch (target)
        //    {
        //        case "goblin":
        //            goblin.Health -= (PlayerCharacter.AttackPower - (1 * goblin.DefencePower));
        //            break;

        //        case "player":
        //            PlayerCharacter.Health -= (goblin.AttackPower - (1 * PlayerCharacter.DefencePower));
        //            break;
        //    }
        //}

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