using csharp.UpdateServices;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose : Inn
    {
        IList<Item> Items;
        //Possible to make ItemUpdater an implementation of an interface and inject it, but right now there is no reason for that.
        private readonly ItemUpdater _itemUpdater;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
            _itemUpdater = new ItemUpdater();
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                //Not switch in order to use Contains

                //It is not stated, but if the List is big, it may be worth to group it by name, in this case it is not worth it though
                if (item.Name.Contains("Aged Brie"))
                {
                    _itemUpdater.SetUpdateStrategy(new AgedBrieUpdater());
                }
                else if (item.Name.Contains("Sulfuras"))
                {
                    _itemUpdater.SetUpdateStrategy(new SulfurasUpdater());
                }
                else if (item.Name.Contains("Backstage passes"))
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
        }
    }
}
