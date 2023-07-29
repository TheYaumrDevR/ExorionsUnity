using System;
using System.Collections.Generic;

namespace Org.Ethasia.Evocri.Core
{
    public class Battle
    {
        private IndividualExorion enemyTeamOne;
        private IndividualExorion enemyTeamTwo;

        private Action<List<IndividualExorion>> battleActionTeamOne;
        private Action<List<IndividualExorion>> battleActionTeamTwo;

        public void StartBattle(IndividualExorion enemyTeamOne, IndividualExorion enemyTeamTwo)
        {

        }

        public void InputCommandTeamOne(Action<List<IndividualExorion>> battleAction)
        {
            if (null == battleActionTeamOne)
            {
                battleActionTeamOne = battleAction;
            }
            
            ExecuteQueuedBattleActions();
            // Check speed value when executing.
            // Use the command instead of Action
            // Use builders to create commands
            // Write Unit Tests
            // Incorporate crit chance
        }

        public void InputCommandTeamTwo(Action<List<IndividualExorion>> battleAction)
        {
            if (null == battleActionTeamTwo)
            {
                battleActionTeamTwo = battleAction;
            }

            ExecuteQueuedBattleActions();
        }

        private void ExecuteQueuedBattleActions()
        {
            if (null != battleActionTeamOne && null != battleActionTeamTwo)
            {

            }
        }
    }
}