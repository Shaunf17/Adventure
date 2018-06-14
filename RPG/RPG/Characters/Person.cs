using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Characters
{
    public class Person
    {
        public int Health { get; set; }
        public int Mana { get; set; }
        public int AttackPower { get; set; }
        public int DefencePower { get; set; }

        public PlayerClass PlayerClass { get; set; }
    }
}
