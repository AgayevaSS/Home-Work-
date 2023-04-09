using System;

namespace Work1
{
    public class Enemy : Character
    {
        public int DangerLevel { get; set; }
        public int Experience { get; set; }

        public new virtual void Attack()
        {
            Console.WriteLine($"{Name} attacks the player with a special move!");
        }

        public new string Name { get; set; }
        

        public static void Die(string name)
        {
            Console.WriteLine($"{name} drops experience!");
        }
    }
   

}
