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
        }

        public override int Attack()
        {
            Random rnd = new Random();
            int damage = rnd.Next(20, 30);
            return damage;
        }

    }
}
