using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Colour
    {
        /// <summary>
        /// <para>Sets the console output text colour. The colour is only changed once the method is re-called</para>
        /// </summary>
        /// <param name="colour"></param>
        public static void Set(string colour)
        {
            switch (colour)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "black":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "dark red":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "dark blue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "dark yellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "dark magenta":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "dark cyan":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "dark green":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "dark gray":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
            }
        }
    }
}
