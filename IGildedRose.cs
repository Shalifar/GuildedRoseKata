using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    //The idea is that there may be multiple different inns
    public interface IGildedRose
    {
        void UpdateQuality();
        void SetStockItems(IList<Item> items);
    }
}
