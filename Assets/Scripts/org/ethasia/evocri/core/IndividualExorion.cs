using System.Collections.Generic;

namespace Org.Ethasia.Evocri.Core
{
    public class IndividualExorion
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
            set;
        }

        private BattleAbility abilitySlotOne;

        public IndividualExorion()
        {
            maxHp = 150;
            CurrentHp = 150;
        }

        public void EquipAbilityOnSlotOne(BattleAbility ability)
        {
            abilitySlotOne = ability;
        }

        public int CalculateSlotOneAbilityActionSpeed()
        {
            if (null != abilitySlotOne)
            {
                return abilitySlotOne.CalculateActionSpeed(this);
            }

            return 0;
        }
        
        public void UseSlotOneAbility(List<IndividualExorion> targets)
        {
            if (null != abilitySlotOne)
            {
                abilitySlotOne.Use(targets);
            }
        }

        public void ReceiveDamage(int damage)
        {
            CurrentHp = CurrentHp - damage;

            if (CurrentHp < 0)
            {
                CurrentHp = 0;
            }
        }
    }
}