using Org.Ethasia.Evocri.Core;

namespace Org.Ethasia.Evocri.IoAdapters
{
    public class RealIoAdaptersFactory : IoAdaptersFactory
    {
        private static RandomNumberGenerator randomNumberGeneratorInstance;

        public override IRandomNumberGenerator GetRandomNumberGeneratorInstance()
        {
            if (null == randomNumberGeneratorInstance)
            {
                randomNumberGeneratorInstance = new RandomNumberGenerator();
            }

            return randomNumberGeneratorInstance;
        }
    }
}