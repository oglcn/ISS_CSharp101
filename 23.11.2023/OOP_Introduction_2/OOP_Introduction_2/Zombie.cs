using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Introduction_2
{
    internal class Zombie : Enemy
    {

        public Zombie()
        {
            Health = 200;
            minDamage = 20;
            maxDamage = 30;
        }

        public override bool TakeDamage(int damage, string enemyName)
        {
            Console.WriteLine("Zombie Taking Damage: ");
            return base.TakeDamage(damage, enemyName);
        }

    }
}
