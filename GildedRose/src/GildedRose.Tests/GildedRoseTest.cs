using System.Collections.Generic;
using FluentAssertions;
using GildedRose.Items;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Tests
{
    [TestClass]
    public class GildedRoseTest
    {
        [TestMethod]
        public void TestUpdateQuality()
        {
            var items = ItemRepository.GetItems();
            GildedRose gildedRose = new GildedRose(items);

            var itemsGoldenMaster = ItemRepository.GetItems();
            GildedRoseGoldenMaster gildedRoseGoldenMaster = new GildedRoseGoldenMaster(itemsGoldenMaster);


            for (var i = 0; i < 31; i++)
            {
                gildedRose.UpdateQuality();
                gildedRoseGoldenMaster.UpdateQuality();
            }

            items.Should().BeEquivalentTo(itemsGoldenMaster); 
        }
    }
}
