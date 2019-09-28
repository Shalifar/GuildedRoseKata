using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace csharp
{
    static class UnityConfig
    {
        public static UnityContainer GetUnityContainer()
        {
            var container = new UnityContainer();

            container.RegisterType<IGildedRose, GildedRose>();

            return container;
        }
    }
}
