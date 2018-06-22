using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Utilities;
using RPG.Magic;

namespace RPG.Characters
{
    public class PlayerClass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ClassColour { get; set; }

        public List<School> Schools = new List<School>();
        public List<String> Test { get; set; }

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

            Schools.Add(new Warfare() { });
            Schools.Add(new Pyromancy() { });
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

            Schools.Add(new Pyromancy() { });
            Schools.Add(new Hydromancy() { });
            Schools.Add(new Geomancy() { });
            Schools.Add(new Aeromancy() { });
            Schools.Add(new Arcana() { });
        }
    }

    public class Paladin : PlayerClass
    {
        public Paladin()
        {
            ID = 4;
            Name = "Paladin";
            ClassColour = "yellow";
            Description = "Utilising MIGHT and WISDOM, the Paladin seeks to rid the world of evil-doers. Taking authority into their own hands, the use sword and spell to dispense justice";
        }
    }

    public class Necromancer : PlayerClass
    {
        public Necromancer()
        {
            ID = 5;
            Name = "Necromancer";
            ClassColour = "darkMagenta";
            Description = "Chanelling dark magic, the Necromancer approaches combat with unquestionable INTELLIGENCE and heart CONSTITUTION, providing enough innate ability and staying power to raise the dead and turn the tide of battle";
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
            ClassList.Add(new Necromancer { });
        }

        public void PrintList()
        {
            foreach (var item in ClassList)
            {
                Print.SlowLine(String.Format("Name: {0} \nDescription: {1}", item.Name, item.Description), 0, item.ClassColour);
                Print.Slow("Schools: \t");
                foreach(var school in item.Schools)
                {
                    Print.Slow(school.Name + "\t");
                }
                Print.SlowLine("\n");
            }
        }

        public PlayerClass Find(string name)
        {
            var item = ClassList.Find(c => c.Name.ToUpper() == name.ToUpper());

            return item;
        }
    }
}
