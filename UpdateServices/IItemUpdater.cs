using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.UpdateServices
{
    public interface IItemUpdater
    {
        void SetUpdateStrategy(UpdateStrategy updateStrategy);
        void Update(Item item);
    }
}
