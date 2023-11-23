using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Introduction_2
{
    class GenericEntity
    {
        int DefaultHealth = 100;
        protected int minDamage = 5;
        protected int maxDamage = 10;
        public int Health { get; set; }
        public string Name { get; set; }

        public GenericEntity()
        {
            Health = DefaultHealth;
        }

        public int Attack()
        {
            Random rnd = new Random();
            int damage = rnd.Next(minDamage, maxDamage);
            return damage;
        }

        public virtual bool TakeDamage(int damage, string enemyName)
        {
            Health -= damage;
            Console.WriteLine("Damage: " + damage);

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
            return "Name: " + Name +" Health: " + Health;
        }
    }
}
