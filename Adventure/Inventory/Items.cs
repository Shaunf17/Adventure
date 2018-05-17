using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Items
    {

    }

    public class Weapon : Items
    {
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int Value { get; set; }

        public void PrintDetails()
        {
            string display = string.Format("Name: {0} \nAttack Power: {1} \nValue: {2}", Name, AttackPower, Value);
            Console.Write(display);
        }
    }
}
