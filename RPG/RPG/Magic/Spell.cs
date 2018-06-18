using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Magic
{
    public class Spell
    {
        public int ID { get; set; }
        public int Level { get; set; }
        public int Cost { get; set; }
        public int AOE { get; set; }
        public int Range { get; set; }
        public string Description { get; set; }

        public School School { get; set; }
    }

    public class Fireball : Spell
    {
        public Fireball()
        {
            ID = 1;

            School = new Pyromancy();
        }
    }
}
