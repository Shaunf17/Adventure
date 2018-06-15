using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Inventory;
using RPG.Items;

namespace RPG.Characters
{
    public class Player : Person
    {
        public string Name { get; set; }

        public InventoryManager Inventory { get; set; }
        public PlayerClass PlayerClass { get; set; }


        public Player(string Name, int Health, int Mana, int AttackPower, int DefencePower, PlayerClass PlayerClass)
        {
            this.Name = Name;
            this.Health = Health;
            this.Mana = Mana;
            this.AttackPower = AttackPower;
            this.DefencePower = DefencePower;

            this.PlayerClass = PlayerClass;
        }

        public void Add(string item)
        {
            Console.WriteLine("Added {0} to inventory", item);
        }

        public void PrintStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Health: {0}", Health);
            Console.WriteLine("Mana: {0}", Mana);
            Console.WriteLine("Attack Power: {0}", AttackPower);
            Console.WriteLine("Defense Power: {0}", DefencePower);
        }
    }
}
