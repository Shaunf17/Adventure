using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Utilities;

namespace RPG.Characters
{
    public class PlayerClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ClassColour { get; set; }

        public void ModifyPlayer(int stat)
        {
            Console.WriteLine("{0} ID is: {1}", Name, ID);
        }
    }

    public class Warrior : PlayerClass
    {
        public Warrior()
        {
            ID = 1;
            Name = "Warrior";
            ClassColour = "red";
            Description = "Born and bred for war, this class excels in all things physical. Using their brute MIGHT and CONSTITUTION the Warrior can cleave a path wherever they so desire"; 
        }
    }

    public class Rogue : PlayerClass
    {
        public Rogue()
        {
            ID = 2;
            Name = "Rogue";
            ClassColour = "darkGreen";
            Description = "Taking a more finnesse approach, the Rogue's AGILITY and AWARENESS allows them to move stealthily through any dangerous environment";
        }
    }

    public class Mage : PlayerClass
    {
        public Mage()
        {
            ID = 3;
            Name = "Mage";
            ClassColour = "blue";
            Description = "Calling upon their WISDOM and INTELLIGENCE, the Mage can diffuse any situation with a carefully cast spell or apt potion";
        }
    }

    public class Paladin : PlayerClass
    {
        public Paladin()
        {
            ID = 4;
            Name = "Paladin";
            ClassColour = "darkYellow";
            Description = "Utilising MIGHT and WISDOM, the Paladin seeks to rid the world of evil-doers. Taking authority into their own hands, the use sword and spell to dispense justice";
        }
    }


    public class PlayerClassList
    {
        List<PlayerClass> ClassList = new List<PlayerClass>();

        public void CreateClassList()
        {
            ClassList.Add(new Warrior { });
            ClassList.Add(new Mage { });
            ClassList.Add(new Rogue { });
            ClassList.Add(new Paladin { });
        }

        public void PrintList()
        {
            foreach (var item in ClassList)
            {
                Print.SlowLine(String.Format("Name: {0} \tID: {1} \tDescription: {2}", item.Name, item.ID, item.Description), 0, item.ClassColour);
            }
        }

        public PlayerClass Find(string find)
        {
            foreach (var item in ClassList)
            {
                if (find.ToUpper() == item.Name.ToUpper())
                {
                    return item;
                }
            }
            return null;
        }
    }
}
