using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Introduction_2
{
    internal class Enemy : GenericEntity
    {

        int DefaultHealth = 200;




        public Enemy()
        {
            Health = DefaultHealth;
            minDamage = 10;
            maxDamage = 15;
        }



        
    }
}
