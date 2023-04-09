namespace Work1
{
    public class TreasureChest
    {
        private int gold;
        private string item;

        public TreasureChest(int gold, string item)
        {
            this.gold = gold;
            this.item = item;
        }

        public int GetGold()
        {
            return gold;
        }

        public string GetItem()
        {
            return item;
        }

    }
}
