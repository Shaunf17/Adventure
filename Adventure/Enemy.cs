using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int DefencePower { get; set; }
    }

    public class Goblin : Enemy
    {
        public Goblin()
        {
            Name = "Goblin";
            Health = 10;
            AttackPower = 2;
            DefencePower = 1;
        }
    }
}
