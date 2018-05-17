using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class PatternMatcher
    {
        CombatLauncher combat;
        Inventory inventory;
        Map map;

        string userInput;
        string[] split;
        char delimiter = ' ';

        public PatternMatcher(CombatLauncher combat, Inventory inventory, Map map)
        {
            this.combat = combat;
            this.inventory = inventory;
            this.map = map;
        }

        public void Pattern(string userInput)
        {
            this.userInput = userInput;

            split = userInput.Split(delimiter);

            Console.WriteLine("split[0] = {0}\tsplit[1] = {1}", split[0], split[1]);

            switch(split[0])
            {
                case "attack":
                case "Attack":
                case "fight":
                case "Fight":
                    break;
            }
        }
    }
}
