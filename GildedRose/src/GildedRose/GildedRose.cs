using System.Collections.Generic;
using GildedRose.Items;

namespace GildedRose
{
    public class GildedRose
    {
        private const string AgedBrie = "Aged Brie";
        private const string BackstagePassesToATafkal80EtcConcert = "Backstage passes to a TAFKAL80ETC concert";
        private const string SulfurasHandOfRagnaros = "Sulfuras, Hand of Ragnaros";

        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (item.Name != AgedBrie && item.Name != BackstagePassesToATafkal80EtcConcert)
                {
                    if (item.Quality > 0)
                    {
                        if (item.Name != SulfurasHandOfRagnaros)
                        {
                            DecreaseQuality(item);
                        }
                    }
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        UpdateQuality(item);

                        if (item.Name == BackstagePassesToATafkal80EtcConcert)
                        {
                            if (item.SellIn < 11)
                            {
                                UpdateQualityIfPossible(item);
                            }

                            if (item.SellIn < 6)
                            {
                                UpdateQualityIfPossible(item);
                            }
                        }
                    }
                }

                if (item.Name != SulfurasHandOfRagnaros)
                {
                    DecreaseSellIn(item);
                }

                if (item.SellIn < 0)
                {
                    if (item.Name != AgedBrie)
                    {
                        if (item.Name != BackstagePassesToATafkal80EtcConcert)
                        {
                            if (item.Quality > 0)
                            {
                                if (item.Name != SulfurasHandOfRagnaros)
                                {
                                    DecreaseQuality(item);
                                }
                            }
                        }
                        else
                        {
                            item.Quality = 0;
                        }
                    }
                    else
                    {
                        UpdateQualityIfPossible(item);
                    }
                }
            }
        }

        private static void UpdateQualityIfPossible(Item item)
        {
            if (item.Quality < 50)
            {
                UpdateQuality(item);
            }
        }

        private static void DecreaseSellIn(Item item)
        {
            item.SellIn -= 1;
        }

        private static void DecreaseQuality(Item item)
        {
            item.Quality -= 1;
        }

        private static void UpdateQuality(Item item)
        {
            item.Quality += 1;
        }
    }
}
