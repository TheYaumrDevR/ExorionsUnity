namespace Org.Ethasia.Evocri.Core
{
    public class IndividualExorion
    {
        private int maxHp;
        private int currentHp;

        private BattleAbility abilitySlotOne;

        public void EquipAbilityOnSlotOne(BattleAbility ability)
        {
            abilitySlotOne = ability;
            maxHp = 150;
            currentHp = 150;
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