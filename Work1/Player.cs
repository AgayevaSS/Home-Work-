using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Work1
{
    public class Player
    {
        public string Name { get; set; }
        public int Health {get; set; }
        public int Mana { get; set; }
        public string Inventory { get; set; }

        // constructor
        public Player(string name, string inventory,int health, int mana)
        {
            Name = name;
            Inventory = inventory;
            Health = health;
            Mana = mana;
            
        }

        public void Attack(string Name1, string Name2 )
        {
            Console.WriteLine(Name1 + " attack " + Name2 );
        }

        public void UseItem(string inventory, string Name)
        {
            Console.WriteLine(Name + " used item: " + inventory);
        }
    }
}