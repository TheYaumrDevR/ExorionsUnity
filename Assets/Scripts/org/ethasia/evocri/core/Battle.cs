namespace Org.Ethasia.Evocri.Core
{
    public class Battle
    {
        private IndividualExorion enemyTeamOne;
        private IndividualExorion enemyTeamTwo;

        private BattleCommand battleActionTeamOne;
        private BattleCommand battleActionTeamTwo;

        public void StartBattle(IndividualExorion enemyTeamOne, IndividualExorion enemyTeamTwo)
        {
            this.enemyTeamOne = enemyTeamOne;
            this.enemyTeamTwo = enemyTeamTwo;
        }

        public void InputCommandTeamOne(BattleCommand battleAction)
        {
            if (null == battleActionTeamOne)
            {
                battleActionTeamOne = battleAction;
                ExecuteQueuedBattleActions();
            }

            // End battle when one team faints
            // Incorporate crit chance
        }

        public void InputCommandTeamTwo(BattleCommand battleAction)
        {
            if (null == battleActionTeamTwo)
            {
                battleActionTeamTwo = battleAction;
                ExecuteQueuedBattleActions();
            }
        }

        private void ExecuteQueuedBattleActions()
        {
            if (null != battleActionTeamOne && null != battleActionTeamTwo)
            {
                if (battleActionTeamOne.GetActionSpeed() >= battleActionTeamTwo.GetActionSpeed())
                {
                    battleActionTeamOne.Execute();
                    battleActionTeamTwo.Execute();
                }
                else
                {
                    battleActionTeamTwo.Execute();
                    battleActionTeamOne.Execute();
                }

                battleActionTeamOne = null;
                battleActionTeamTwo = null;
            }
        }
    }
}