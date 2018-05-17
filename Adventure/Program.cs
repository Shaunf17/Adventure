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

        static Program program = new Program();
        CombatLauncher combat;
        PatternMatcher pattern;
        

        public Program()
        {
            combat = new CombatLauncher();
            pattern = new PatternMatcher();
        }

        static void Main(string[] args)
        {
            program.StartGame();
            Console.ReadLine();
        }

        public void StartGame()
        {
            Colour.Set("cyan");
            Console.WriteLine("Welcome, Adventurer...");

            Colour.Set("white");
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

        public void PatternMathcer(string userInput)
        {

        }

        public void Run()
        { }
    }
}