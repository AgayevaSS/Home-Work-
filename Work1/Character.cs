using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    public partial class Character
    {
        public string Name { get; set; }
        private readonly int _health;
        public int Damage { get; set; }

        public void Attack()
        {
            Console.WriteLine($"{Name} has died!");
        }
    }
}
