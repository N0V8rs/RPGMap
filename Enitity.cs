using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RPGMap
{
    internal class Enitity 
    {
        public Enitity() 
        {
            Console.WriteLine("Enitity Code Loaded");
        }

        public int x;
        public int y;

        public int Health;

        public void Heal(int hp)
        {
            Health += hp;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
