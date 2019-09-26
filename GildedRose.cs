﻿using csharp.UpdateServices;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose : IGildedRose
    {
        IList<Item> Items;
        private readonly ItemUpdater _itemUpdater;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
            _itemUpdater = new ItemUpdater();
        }

        public void UpdateQuality()
        {
            foreach(var item in Items)
            {
                //Not switch in order to use Contains

                //It is not stated, but if the List is big, it may be worth to group it by name, in this case it is not worth it though
                if(item.Name == "Aged Brie")
                {
                    _itemUpdater.SetUpdateStrategy(new AgedBrieUpdater());
                }
                else if (item.Name == "Sulfuras, Hand of Ragnaros")
                {
                    _itemUpdater.SetUpdateStrategy(new SulfurasUpdater());
                }
                else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    _itemUpdater.SetUpdateStrategy(new BackstagePassesUpdater());
                }
                else if (item.Name.Contains("Conjured"))
                {
                    _itemUpdater.SetUpdateStrategy(new ConjuredItemUpdater());
                }
                else
                {
                    _itemUpdater.SetUpdateStrategy(new BasicUpdater());
                }

                _itemUpdater.Update(item);
            }

            //for (var i = 0; i < Items.Count; i++)
            //{
            //    if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
            //    {
            //        if (Items[i].Quality > 0)
            //        {
            //            if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //            {
            //                Items[i].Quality = Items[i].Quality - 1;
            //            }
            //        }
            //    }
            //    else
            //    {
            //        if (Items[i].Quality < 50)
            //        {
            //            Items[i].Quality = Items[i].Quality + 1;

            //            if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
            //            {
            //                if (Items[i].SellIn < 11)
            //                {
            //                    if (Items[i].Quality < 50)
            //                    {
            //                        Items[i].Quality = Items[i].Quality + 1;
            //                    }
            //                }

            //                if (Items[i].SellIn < 6)
            //                {
            //                    if (Items[i].Quality < 50)
            //                    {
            //                        Items[i].Quality = Items[i].Quality + 1;
            //                    }
            //                }
            //            }
            //        }
            //    }

            //    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //    {
            //        Items[i].SellIn = Items[i].SellIn - 1;
            //    }

            //    if (Items[i].SellIn < 0)
            //    {
            //        if (Items[i].Name != "Aged Brie")
            //        {
            //            if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
            //            {
            //                if (Items[i].Quality > 0)
            //                {
            //                    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
            //                    {
            //                        Items[i].Quality = Items[i].Quality - 1;
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                Items[i].Quality = Items[i].Quality - Items[i].Quality;
            //            }
            //        }
            //        else
            //        {
            //            if (Items[i].Quality < 50)
            //            {
            //                Items[i].Quality = Items[i].Quality + 1;
            //            }
            //        }
            //    }
            //}
        }
    }
}
