using Org.Ethasia.Evocri.Core;
using Org.Ethasia.Evocri.IoAdapters;

namespace Org.Ethasia.Evocri
{
    public class Dependencies
    {
        public static void Inject()
        {
            IoAdaptersFactory.SetInstance(new RealIoAdaptersFactory());
        }
    }
}