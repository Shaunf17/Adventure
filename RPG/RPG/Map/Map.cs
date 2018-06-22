using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Characters;
using RPG.Items;
using RPG.Utilities;


namespace RPG.Map
{
    public class GameMap
    {
        //public int Size { get; set; }
        //public

        public string[,] MapArray { get; set; }
        public string Point { get; set; }
        public int CurrentX { get; set; }
        public int CurrentY { get; set; }
        
        public GameMap()
        {
            CurrentX = 5;
            CurrentY = 5;
            Point = "X";

            MapArray = new string[10,10];

            for (int y = 0; y < MapArray.GetLength(1); y++)
            {
                for (int x = 0; x < MapArray.GetLength(0); x++)
                {
                    MapArray[x, y] = "0";
                }
            }

            MapArray[CurrentX, CurrentY] = Point;
        }

        public void PrintMap()
        {
            for (int y = 0; y < MapArray.GetLength(1); y++)
            {
                for (int x = 0; x < MapArray.GetLength(0); x++)
                {
                    Console.Write(MapArray[x, y]);
                    Console.Write("\t");
                }

                Console.WriteLine(""); 
            }
        }



    }
}
