using System.Collections.Generic;

namespace GildedRose.Items
{
    public class ItemRepository
    {
        public static IList<Item> GetItems()
        {
            return new List<Item>{
                new CommonItem() {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new AgedBrie() {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new CommonItem() {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Sulfuras() {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Sulfuras {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new BackstagePasses()
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new BackstagePasses()
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new BackstagePasses()
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
                new AgedBrie() {Name = "Aged Brie", SellIn = -1, Quality = 6},
                new CommonItem() {Name = "Elixir of the Mongoose", SellIn = -5, Quality = 7},
                new BackstagePasses() {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = -3, Quality = 6},
                // this conjured item does not work properly yet
                new CommonItem() {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
        }

    }
}
