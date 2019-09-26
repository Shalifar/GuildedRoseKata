using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.UpdateServices
{
    class ItemUpdater
    {
        private UpdateStrategy _updateStrategy;

        public void SetUpdateStrategy(UpdateStrategy updateStrategy)
        {
            _updateStrategy = updateStrategy;
        }

        public void Update(Item item)
        {
            _updateStrategy.Update(item);
        }
    }
}
