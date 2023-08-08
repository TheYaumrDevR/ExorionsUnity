namespace Org.Ethasia.Evocri.Core
{
    public class IndividualExorionStats
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

        public int CriticalStrikeChanceInTenThousandths
        {
            get;
            private set;
        }

        public float CriticalDamageMultiplier
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
            private int criticalStrikeChanceInTenThousandths;
            private float criticalDamageMultiplier;

            public IndividualExorionStatsBuilder()
            {
                criticalDamageMultiplier = 1.5f;
                criticalStrikeChanceInTenThousandths = 2000;
            }

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

            public IndividualExorionStatsBuilder SetCriticalStrikeChanceInTenThousandths(int value)
            {
                criticalStrikeChanceInTenThousandths = value;
                return this;
            }  

            public IndividualExorionStatsBuilder SetCriticalDamageMultiplier(float value)
            {
                criticalDamageMultiplier = value;
                return this;
            }                           

            public IndividualExorionStats Build()
            {
                product = new IndividualExorionStats();

                product.maxHp = maxHp;
                product.CurrentHp = currentHp;
                product.AttackSpeed = attackSpeed;
                product.CriticalStrikeChanceInTenThousandths = criticalStrikeChanceInTenThousandths;
                product.CriticalDamageMultiplier = criticalDamageMultiplier;

                return product;
            }                     
        }
    }
}