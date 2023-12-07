using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_Forms.Entitites
{
    internal class GenericEntity
    {
        static int DefaultHealth = 100;
        protected static int DefaultMinDamage = 5;
        protected static int DefaultMaxDamage = 10;

        protected int _health = 0;
        public string Name { get; set; }
        public int Health { get { return _health; }}
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }




       
        public GenericEntity(string Name): this(Name,DefaultHealth)
        {
            //_health = DefaultHealth;
            //this.Name = Name;
        }
        public GenericEntity(string Name, int Health):this(Name,Health,DefaultMinDamage,DefaultMaxDamage)
        {
            //this.Name = Name;
            //_health = Health;

        }

        public GenericEntity(string Name, int Health, int minDamage) : this(Name, Health, minDamage, DefaultMaxDamage)
        {
            //this.Name = Name;
            //_health = Health;

        }
        public GenericEntity(string Name, int Health, int minDamage, int maxDamage)
        {
            _health = Health;
            this.Name = Name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public int Attack(GenericEntity entity)
        {
            Random rnd = new Random();
            int damage = rnd.Next(minDamage, maxDamage);
            entity.TakeDamage(damage);
            return damage;
        }

        public virtual bool TakeDamage(int damage)
        {
            _health -= damage;
            //Console.WriteLine("Damage: " + damage);

            if (Health < 0)
            {
                Console.WriteLine("Killed by: " + enemyName);
                _health = 0;
                return false;
            }
            return true;
        }

        //ToString
        public override string ToString()
        {
            return "Name: " + Name + " Health: " + Health;
        }
    }
}
