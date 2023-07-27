namespace Org.Ethasia.Evocri.Core
{
    public class Battle
    {
        private IndividualExorion enemyTeamOne;
        private IndividualExorion enemyTeamTwo;

        public void StartBattle()
        {
            enemyTeamOne = new IndividualExorion();
            enemyTeamTwo = new IndividualExorion();

            BattleAbility testAbilityOne = new BattleAbility(23);
            BattleAbility testAbilityTwo = new BattleAbility(15);

            enemyTeamOne.EquipAbilityOnSlotOne(testAbilityOne);
            enemyTeamTwo.EquipAbilityOnSlotOne(testAbilityTwo);
        }

        public void InputCommand()
        {
            // Once commands for both enemies are put in execute them.
            // Check speed value when executing.
        }
    }
}