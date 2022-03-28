namespace GildedRose.Items
{
    public class CommonItem : Item
    {
        public override void UpdateQuality()
        {
            DecreaseQualityIfPossible();
            DecreaseSellIn();
            if (SellIn < MinSellIn)
            {
                DecreaseQualityIfPossible();
            }
        }

    }
}
