using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work1;

namespace Work1
{
    public abstract class Creature
    {
        public int Health { get; set; }
        public int Damage { get; set; }

        public abstract void Attack();
    }

    public class IGoblin : Creature
    {
        public override void Attack()
        {
            Console.WriteLine("Goblin attacks with a rusty sword!");
        }
    }

}



