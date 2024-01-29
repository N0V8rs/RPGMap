using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMap
{
    internal class Map 
    {
        public string[] MapX; // Map Layout X
        public char[,] MapY; // Map Layout Y
        public bool Win; // Level Compelete

        public void MapConsole() // Map methods in one
        {
            CreateMap();
            MakeMap();
        }

        public void CreateMap()
        {
            for (int i = 0; i < MapY.Length; i++)
            {
                for (int j = 0; j < MapX[i].Length; j++)
                {
                    MapY[i, j] = MapX[i][j];
                }
            }
        }

        public void MakeMap()
        {
            Console.Clear();

            for(int k = 0; k < MapY.Length; k++)
            {
                for (int l = 0; l < MapX[k].Length; l++)
                {
                    char tle = MapY[k,l];

                    if (tle == '=' && Win == false)
                    {

                    }
                }
            }
        }


    }
}
