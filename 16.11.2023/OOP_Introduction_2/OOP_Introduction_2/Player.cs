using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Introduction_2
{
    internal class Player : GenericEntity
    {

        public Player()
        {
            Health = 1000;
            minDamage = 50;
            maxDamage = 70;
        }

    }
}
