using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.UpdateServices
{
    /// <summary>
    /// Updates backstage passes items
    /// </summary>
    public class BackstagePassesUpdate : UpdateStrategy
    {
        public override void Update(Item item)
        {
            item.SellIn--;

            if (item.SellIn >= 10)
            {
                item.Quality++;
            }
            else if(item.SellIn > 5)
            {
                item.Quality += 2;
            }
            else if(item.SellIn >=0)
            {
                item.Quality += 3;
            }
            else
            {
                item.Quality = 0;
            }

            if(item.Quality > 50)
            {
                item.Quality = 50;
            }            
        }
    }
}
