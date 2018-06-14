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
    }
}
