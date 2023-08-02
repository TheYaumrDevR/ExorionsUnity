namespace Org.Ethasia.Evocri.Core
{
    public struct IndividualExorionStats
    {
        private int maxHp;
        public int CurrentHp
        {
            get;
            private set;
        }

        public int AttackSpeed
        {
            get;
            private set;
        }

        public void SubtractDamage(int damage)
        {
            CurrentHp -= damage;

            if (CurrentHp < 0)
            {
                CurrentHp = 0;
            }            
        }

        public class IndividualExorionStatsBuilder
        {
            private IndividualExorionStats product;

            private int maxHp;
            private int currentHp;
            private int attackSpeed;

            public IndividualExorionStatsBuilder SetMaxHp(int value)
            {
                maxHp = value;
                return this;
            }

            public IndividualExorionStatsBuilder SetCurrentHp(int value)
            {
                currentHp = value;
                return this;
            }

            public IndividualExorionStatsBuilder SetAttackSpeed(int value)
            {
                attackSpeed = value;
                return this;
            }   

            public IndividualExorionStats Build()
            {
                product = new IndividualExorionStats();

                product.maxHp = maxHp;
                product.CurrentHp = currentHp;
                product.AttackSpeed = attackSpeed;

                return product;
            }                     
        }
    }
}