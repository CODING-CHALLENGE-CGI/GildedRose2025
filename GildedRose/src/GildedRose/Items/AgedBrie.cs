using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose.Items
{
    public class AgedBrie : Item

    {

        public override void UpdateQuality()
        {
            IncreaseQualityIfPossible();
            DecreaseSellIn();
            if (SellIn < MinSellIn)
            {
                IncreaseQualityIfPossible();
            }
        }

       
    }
}
