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

    public class Warfare : School
    {
        public Warfare()
        {
            ID = 6;
            Name = "Warfare";
            Descritpion = "";
        }
    }

}
