namespace Org.Ethasia.Evocri.Core
{
    public interface IRandomNumberGenerator
    {
        int GenerateIntegerBetweenAnd(int min, int max);
        int GenerateRandomPositiveInteger(int max);
    }
}