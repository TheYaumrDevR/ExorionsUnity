using System.Collections.Generic;

namespace Org.Ethasia.Evocri.Core
{
    public class IndividualExorion
    {
        private IndividualExorionStats stats;
        private BattleAbility abilitySlotOne;

        public IndividualExorion(IndividualExorionStats stats)
        {
            this.stats = stats;
        }

        public void EquipAbilityOnSlotOne(BattleAbility ability)
        {
            abilitySlotOne = ability;
        }

        public int CalculateSlotOneAbilityActionSpeed()
        {
            if (null != abilitySlotOne)
            {
                return abilitySlotOne.CalculateActionSpeed(stats);
            }

            return 0;
        }
        
        public void UseSlotOneAbility(List<IndividualExorion> targets)
        {
            if (null != abilitySlotOne && stats.CurrentHp > 0)
            {
                abilitySlotOne.Use(targets);
            }
        }

        public void ReceiveDamage(int damage)
        {
            stats.SubtractDamage(damage);
        }
    }
}