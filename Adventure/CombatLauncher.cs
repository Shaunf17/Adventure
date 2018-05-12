using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class CombatLauncher
    {
        public void Combat(Character enemy, Player player)
        {
            enemy = new Goblin();

            Console.Write("You come across a ");
            Colour.Set("red");
            Console.WriteLine(enemy.Name);

            while (enemy.Health > 0)
            {
                Colour.Set("white");
                Console.WriteLine("What do you do?");

                string combatInput = Console.ReadLine();

                switch (combatInput)
                {
                    case "attack":
                        CombatLog(player, player.NormalAttack(), enemy);
                        break;
                    case "run":
                        //Run();
                        break;
                }
                Console.WriteLine("");
                CombatLog(enemy, 5, player);
            }

            Console.WriteLine(string.Format("{0} Defeated!", enemy.Name));
        }

        public void CombatLog(Character name, int damage, Character target)
        {
            target.Health -= damage;

            Console.WriteLine("{0} hit {1} for {2} damage!", name.Name, target.Name, damage);
            Console.WriteLine("{0} health: {1}", target.Name, target.Health);
        }
    }
}
