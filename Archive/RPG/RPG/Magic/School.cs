using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Magic
{
    public class School
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Descritpion { get; set; }
    }

    public class Pyromancy : School
    {
        public Pyromancy()
        {
            ID = 1;
            Name = "Pyromancy";
            Descritpion = "";
        }
    }

    public class Hydromancy : School
    {
        public Hydromancy()
        {
            ID = 2;
            Name = "Hydromancy";
            Descritpion = "";
        }
    }

    public class Geomancy : School
    {
        public Geomancy()
        {
            ID = 3;
            Name = "Geomancy";
            Descritpion = ""; 
        }
    }

    public class Aeromancy : School
    {
        public Aeromancy()
        {
            ID = 4;
            Name = "Aeromancy";
            Descritpion = "";
        }
    }

    public class Arcana : School
    {
        public Arcana()
        {
            ID = 5;
            Name = "Arcana";
            Descritpion = "";
        }
    }

    public class Necromancy : School
    {
        public Necromancy()
        {
            ID = 6;
            Name = "Necromancy";
            Descritpion = "";
        }
    }

    public class Summoning : School
    {
        public Summoning()
        {
            ID = 7;
            Name = "Summoning";
            Descritpion = "";
        }
    }

    public class Warfare : School
    {
        public Warfare()
        {
            ID = 8;
            Name = "Warfare";
            Descritpion = "";
        }
    }

    public class Subterfuge : School
    {
        public Subterfuge()
        {
            ID = 9;
            Name = "Subterfuge";
            Descritpion = "";
        }
    }

    public class Guardian : School
    {
        public Guardian()
        {
            ID = 10;
            Name = "Guardian";
            Descritpion = "";
        }
    }

}
