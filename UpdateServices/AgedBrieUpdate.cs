﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.UpdateServices
{
    /// <summary>
    /// Updates Aged Brie items
    /// </summary>
    public class AgedBrieUpdate : UpdateStrategy
    {
        public override void Update(Item item)
        {
            item.SellIn--;
            if(item.SellIn < 0)
            {
                item.Quality += 2;
            }
            else
            {
                item.Quality++;
            }

            if (item.Quality > 50)
                item.Quality = 50;
        }
    }
}
