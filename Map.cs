using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMap
{
    internal class Map
    {
        public string[] MapX; // Map Layout
        public char[,] MapY; //

        public void CreateMap()
        {
            for (int i = 0; i < MapX.Length; i++)
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

            for(int k = 0; k < MapX.Length; k++)
            {
                for (int l = 0; l < MapX[k].Length; l++)
                {

                }
            }
        }


    }
}
