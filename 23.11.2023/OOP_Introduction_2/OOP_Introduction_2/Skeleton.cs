using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Introduction_2
{
    internal class Skeleton:Enemy
    {
        public Skeleton()
        {
            Health = 300;
        }

        public override bool TakeDamage(int damage, string enemyName)
        {
            Console.WriteLine("Skeleton Taking Damage: ");
            return base.TakeDamage(damage, enemyName);
        }
    }
}
