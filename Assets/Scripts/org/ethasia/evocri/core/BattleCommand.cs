using System.Collections.Generic;

namespace Org.Ethasia.Evocri.Core
{
    public abstract class BattleCommand
    {
        protected List<IndividualExorion> targets;
        protected IndividualExorion source;

        public BattleCommand(List<IndividualExorion> targets, IndividualExorion source)
        {
            this.targets = targets;
            this.source = source;
        }

        public abstract void Execute();
        public abstract int GetActionSpeed();
    }
}