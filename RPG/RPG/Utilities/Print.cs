using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Utilities
{
    public static class Print
    {
        public static void Slow(string text, float speed = 0.0f, string colour = "Gray")
        {
            if (colour != null)
            {
                try
                {
                    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), char.ToUpper(colour[0]) + colour.Substring(1));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.Write(text);
        }

        public static void SlowLine(string text, float speed = 0.0f, string colour = "Gray")
        {
            if (colour != null)
            {
                try
                {
                    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), char.ToUpper(colour[0]) + colour.Substring(1));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.Write("\n" + text);
        }
    }
}
