using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class Map
    {
        int size_x, size_y;
        int[,] map;

        public Map(int size_x, int size_y)
        {
            this.size_x = size_x;
            this.size_y = size_y;

            map = new int[size_x, size_y];

            for (int i = 0; i < size_y; i++)
            {
                for (int j = 0; i < size_x; j++)
                {
                    map[j, i] = 0;
                }
            }
        }

        public void PrintMap()
        {
            for (int i = 0; i < size_y; i++)
            {
                for (int j = 0; j < size_x; j++)
                {
                    if (j == (size_x - 1))
                        Console.Write(map[j, i] + "\n");
                    else
                        Console.Write(map[j, i]);
                }
            }
        }
    }
}
