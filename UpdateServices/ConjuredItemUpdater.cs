using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.UpdateServices
{
    public class ConjuredItemUpdater : UpdateStrategy
    {
        public override void Update(Item item)
        {
            item.SellIn--;
            if(item.SellIn < 0)
            {
                item.Quality -= 4;
            }
            else
            {
                item.Quality -= 2;
            }

            if (item.Quality < 0)
                item.Quality = 0;
        }
    }
}
