using System.Collections.Generic;

namespace Org.Ethasia.Evocri.Core
{
    public abstract class BattleCommand
    {
        protected List<IndividualExorion> targets;

        public BattleCommand(List<IndividualExorion> targets)
        {
            this.targets = targets;
        }

        public abstract void Execute();
    }
}