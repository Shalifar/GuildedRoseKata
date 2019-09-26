using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.UpdateServices
{
    public class BasicUpdater : UpdateStrategy
    {
        public override void Update(Item item)
        {
            item.SellIn--;
            if (item.SellIn < 0)
            {
                DecreaseQuality(item);
                DecreaseQuality(item);
            }
            else
            {
                DecreaseQuality(item);
            }
        }

        private void DecreaseQuality(Item item)
        {
            if (item.Quality > 0)
                item.Quality--;
        }
    }
}
