namespace GildedRose.Items
{
    public abstract class Item
    {
        protected const int MaxQuality = 50;
        protected const int MinSellIn = 0;
        protected const int MinQuality = 0;
        
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public abstract void UpdateQuality();

        protected void IncreaseQualityIfPossible()
        {
            if (Quality < MaxQuality)
            {
                IncreaseQuality();
            }
        }

        protected void DecreaseSellIn()
        {
            SellIn -= 1;
        }

        protected void IncreaseQuality()
        {
            Quality += 1;
        }

        protected void DecreaseQuality()
        {
            Quality -= 1;
        }
        protected void DecreaseQualityIfPossible()
        {
            if (Quality > MinQuality)
            {
                DecreaseQuality();
            }
        }

    }
}
