using System.Collections.Generic;

namespace Org.Ethasia.Evocri.Core
{
    public class IndividualExorion
    {
        public IndividualExorionStats Stats
        {
            get;
            private set;
        }

        private BattleAbility abilitySlotOne;

        public IndividualExorion(IndividualExorionStats stats)
        {
            Stats = stats;
        }

        public void EquipAbilityOnSlotOne(BattleAbility ability)
        {
            abilitySlotOne = ability;
        }

        public int CalculateSlotOneAbilityActionSpeed()
        {
            if (null != abilitySlotOne)
            {
                return abilitySlotOne.CalculateActionSpeed(Stats);
            }

            return 0;
        }
        
        public void UseSlotOneAbility(List<IndividualExorion> targets)
        {
            if (null != abilitySlotOne && Stats.CurrentHp > 0)
            {
                abilitySlotOne.Use(targets);
            }
        }

        public void ReceiveDamage(int damage)
        {
            Stats.SubtractDamage(damage);
        }
    }
}