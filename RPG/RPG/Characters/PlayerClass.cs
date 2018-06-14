using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Characters
{
    public class PlayerClass
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void ModifyPlayer(Player player, PlayerClass playerClass)
        {
            
        }
    }

    public class Warrior : PlayerClass
    {
        public Warrior()
        {
            this.ID = 1;
            this.Name = "Warrior";
        }
    }

    public class Rogue : PlayerClass
    {
        public Rogue()
        {
            this.ID = 2;
            this.Name = "Rogue";
        }
    }

    public class Mage : PlayerClass
    {
        public Mage()
        {
            this.ID = 3;
            this.Name = "Mage";
        }
    }
}
