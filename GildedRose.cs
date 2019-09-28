using csharp.StaticKeys;
using csharp.UpdateServices;
using System.Collections.Generic;

namespace csharp
{
    public class GildedRose : IGildedRose
    {
        IList<Item> Items;

        //Can be injected via itnerface as well, but right now it is not required
        private ItemUpdater _itemUpdater = new ItemUpdater();

        //In case it is needed, dependency classes can be injected
        public GildedRose()
        {
            
        }

        public void UpdateQuality()
        {
            //It is not stated, but if the List is big, it may be worth to group it by name, in this case it is not worth it though
            foreach (var item in Items)
            {
                var strategy = ChooseUpdateStrategy(item.Name);
                _itemUpdater.SetUpdateStrategy(strategy);
                _itemUpdater.Update(item);
            }
        }

        public void SetStockItems(IList<Item> items)
        {
            this.Items = items;
        }

        private UpdateStrategy ChooseUpdateStrategy(string itemName)
        {
            UpdateStrategy updateStrategy;

            //Not switch in order to use Contains
            if (itemName.Contains(SpecificItem.AgedBrie))
            {
                updateStrategy = new AgedBrieUpdate();
            }
            else if (itemName.Contains(SpecificItem.Sulfuras))
            {
                updateStrategy = new SulfurasUpdate();
            }
            else if (itemName.Contains(SpecificItem.BackstagePasses))
            {
                updateStrategy = new BackstagePassesUpdate();
            }
            else if (itemName.Contains(SpecificItem.Conjured))
            {
                updateStrategy = new ConjuredUpdate();
            }
            else
            {
                updateStrategy = new GenericUpdate();
            }

            return updateStrategy;
        }
    }
}
