using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Work1.Character;

namespace Work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.

            Player Shafiqa = new Player("Shafiqa", "sword", 100, 50);
            Player Murad = new Player("Murad", "gun", 100, 70);
            Shafiqa.Attack(Shafiqa.Name, Murad.Name);
            Shafiqa.UseItem(Shafiqa.Inventory, Shafiqa.Name);
            Murad.Attack(Murad.Name, Shafiqa.Name);
            Murad.UseItem(Murad.Inventory, Murad.Name);

            // .

            Participant participant = new Participant()
            {
                Name = "Sabir",
            };
            Console.WriteLine(participant.Name);

            Enemy enemy = new Enemy();
            enemy.Name = "Goblin";
            enemy.Attack();

            Weapon myWeapon = new Weapon(10, 50);

        }
        private object[] inventory = new object[10];

        public void AddToInventory(object item)
        {
            if (item is Weapon)
            {
                Weapon weapon = (Weapon)item;
                for (int i = 0; i < inventory.Length; i++)
                {
                    if (inventory[i] == null)
                    {
                        inventory[i] = weapon;
                        Console.WriteLine($"Added {weapon.Name} to inventory.");
                        return;
                    }
                    else if (item is Potion)
                    {
                        Potion potion = (Potion)item;
                        for (int j = 0; j < inventory.Length; j++)
                        {
                            if (inventory[j] == null)
                            {
                                inventory[j] = potion;
                                Console.WriteLine($"Added {potion.Name} to inventory.");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Invalid item type. Cannot add to inventory.");
                            }
                        }
                    }

                }
            }
        }

    }
}
