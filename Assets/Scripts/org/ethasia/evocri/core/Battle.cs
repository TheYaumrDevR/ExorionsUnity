namespace Org.Ethasia.Evocri.Core
{
    public class Battle
    {
        private IndividualExorion enemyTeamOne;
        private IndividualExorion enemyTeamTwo;

        private BattleCommand battleActionTeamOne;
        private BattleCommand battleActionTeamTwo;

        public bool BattleHasEnded
        {
            get;
            private set;
        }

        public void StartBattle(IndividualExorion enemyTeamOne, IndividualExorion enemyTeamTwo)
        {
            this.enemyTeamOne = enemyTeamOne;
            this.enemyTeamTwo = enemyTeamTwo;
            BattleHasEnded = false;
        }

        public void InputCommandTeamOne(BattleCommand battleAction)
        {
            if (null == battleActionTeamOne && !BattleHasEnded)
            {
                battleActionTeamOne = battleAction;
                ExecuteQueuedBattleActions();
            }

            // Incorporate crit chance
            // Add battle log
        }

        public void InputCommandTeamTwo(BattleCommand battleAction)
        {
            if (null == battleActionTeamTwo && !BattleHasEnded) 
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

                if (0 == enemyTeamOne.Stats.CurrentHp || 0 == enemyTeamTwo.Stats.CurrentHp) 
                {
                    BattleHasEnded = true;
                }

                battleActionTeamOne = null;
                battleActionTeamTwo = null;
            }
        }
    }
}