﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGMap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enitity enitity = new Enitity();
            Map map = new Map();
            Player player = new Player();

            map.MapConsole();
            
            Console.WriteLine(player.Health);
            Console.ReadKey(true);
        }
    }
}
