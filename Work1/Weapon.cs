namespace Work1
{
    public partial class Character
    {
        public class Weapon
        {
            public string Name { get; set; }
            public int Damage { get; set; }
            public int Durability { get; set; }

            public Weapon(int damage, int durability)
            {
                Damage = damage;
                Durability = durability;
            }
        }

    }
}
