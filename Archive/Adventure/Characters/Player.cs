using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Player : Character
    {
        //public string Name { get; set; }
        //public int Health { get; set; }
        //public int AttackPower { get; set; }
        //public int DefencePower { get; set; }
        public int Strength { get; set; }
        public int Perception { get; set; }
        public int Luck { get; set; }
        public int Intunement { get; set; }
        public int SP { get; set; }
        public int MP { get; set; }

        public Player(string name)
        {
            Name = name;
            Health = 20;
            AttackPower = 5;
            DefencePower = 2;
            Strength = 2; 
            Perception = 3;
            Intunement = 2;
            Luck = 2;
            SP = 10;
            MP = 10;
        }

        public int NormalAttack()
        {
            return AttackPower;
        }

        public int Defence()
        {
            return DefencePower;
        }

        public int PowerAttack()
        {
            if (SP.Equals(0))
                return -1;
            else
                return AttackPower + (int)(Math.Log(Strength));
        }
    }
}
