using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Introduction_2
{
    internal class Enemy
    {

        int DefaultHealth = 100;
        public int Health { get; set; }
        public string Name { get; set; }

        public Enemy()
        {
            Health = DefaultHealth;
        }

        //public Enemy(int health)
        //{
        //    Health = health;
        //}


        public virtual int Attack()
        {
            Random rnd = new Random();
            int damage = rnd.Next(5, 10);
            return damage;
        }

        public bool TakeDamage(int damage, string enemyName)
        {
            Health -= damage;

            if (Health < 0)
            {
                Console.WriteLine("Killed by: " + enemyName);
                return false;
            }
            return true;
        }

        //ToString
        public override string ToString()
        {
            return "Health: " + Health;
        }
    }
}
