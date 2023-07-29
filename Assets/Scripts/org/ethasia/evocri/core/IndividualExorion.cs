using System.Collections.Generic;

namespace Org.Ethasia.Evocri.Core
{
    public class IndividualExorion
    {
        private int maxHp;
        private int currentHp;
        public int AttackSpeed
        {
            get;
            set;
        }

        private BattleAbility abilitySlotOne;

        public IndividualExorion()
        {
            maxHp = 150;
            currentHp = 150;
        }

        public void EquipAbilityOnSlotOne(BattleAbility ability)
        {
            abilitySlotOne = ability;
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
            currentHp = currentHp - damage;

            if (currentHp < 0)
            {
                currentHp = 0;
            }
        }
    }
}