﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    public interface IGildedRose
    {
        void UpdateQuality();
        void SetStockItems(IList<Item> items);
    }
}
