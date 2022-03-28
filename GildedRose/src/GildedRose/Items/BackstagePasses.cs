using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Items
{
    public class BackstagePasses : Item
    {
        private const int DoubleThreshold = 11;
        private const int TripleThreshold = 6;

        public override void UpdateQuality()
        {
            IncreaseQualityIfPossible();
            if (SellIn < DoubleThreshold)
            {
                IncreaseQualityIfPossible();
            }
            if (SellIn < TripleThreshold)
            {
                IncreaseQualityIfPossible();
            }
            DecreaseSellIn();
            if (SellIn < MinSellIn)
            {
                Quality = MinQuality;
            }
        }
    }
}
