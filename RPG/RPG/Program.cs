using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Utilities;
using RPG.Characters;
using RPG.Map;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface.Initialize();
            UserInterface.CreatePlayer();
        }
    }
}
