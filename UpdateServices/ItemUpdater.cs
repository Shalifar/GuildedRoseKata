using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.UpdateServices
{
    /// <summary>
    /// Class responsible for Item stat updates
    /// </summary>
    class ItemUpdater
    {
        private UpdateStrategy _updateStrategy;

        /// <summary>
        /// Method to set UpdateStrategy
        /// </summary>
        /// <param name="updateStrategy"></param>
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
