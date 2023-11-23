using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Introduction_2
{
    internal class Creeper : Enemy
    {

        public Creeper()
        {
            Health = 500;
        }

        public override bool TakeDamage(int damage, string enemyName)
        {
            Console.WriteLine("Creeper Taking Damage: ");
            return base.TakeDamage(damage, enemyName);
        }


    }
}
