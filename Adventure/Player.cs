using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int DefencePower { get; set; }
        public int Strength { get; set; }
        public int Perception { get; set; }
        public int Luck { get; set; }

        public Player(string name)
        {
            Name = name;
            Health = 20;
            AttackPower = 5;
            DefencePower = 2;
            Strength = 2; 
            Perception = 1;
            Luck = 2; 
        }

        public int NormalAttack()
        {
            int attack = AttackPower;
            return 5;
        }
    }
}
