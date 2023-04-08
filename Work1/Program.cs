using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player Shafiqa = new Player("Shafiqa", "sword", 100, 50);
            Player Murad = new Player("Murad", "gun", 100, 70);
            Shafiqa.Attack(Shafiqa.Name, Murad.Name);
            Shafiqa.UseItem(Shafiqa.Inventory, Shafiqa.Name);
            Murad.Attack(Murad.Name, Shafiqa.Name);
            Murad.UseItem(Murad.Inventory, Murad.Name);

        }
    }
}
