using System.Collections.Generic;

namespace Org.Ethasia.Evocri.Core
{
    public class UseBattleAbilityOnSlotOneCommand : BattleCommand
    {
        public IndividualExorion Source
        {
            set;
            private get;
        }

        public UseBattleAbilityOnSlotOneCommand(List<IndividualExorion> targets) : base(targets) {}

        public override void Execute()
        {
            Source.UseSlotOneAbility(targets);
        }
    }
}