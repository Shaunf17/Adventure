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
    public static class Program
    {
        public static void Main(string[] args)
        {
            UserInterface.Initialize();
            UserInterface.CreatePlayer();

            UserInterface.MainLoop();
        }

        public static void Exit()
        {
            Exit(0);
        }

        public static void Exit(int exitCode)
        {
            Environment.Exit(exitCode);
        }
    }
}
