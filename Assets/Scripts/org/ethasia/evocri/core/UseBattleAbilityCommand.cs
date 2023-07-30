using System.Collections.Generic;

namespace Org.Ethasia.Evocri.Core
{
    public class UseBattleAbilityOnSlotOneCommand : BattleCommand
    {
        public UseBattleAbilityOnSlotOneCommand(List<IndividualExorion> targets, IndividualExorion source) : base(targets, source) {}

        public override void Execute()
        {
            if (source.CurrentHp > 0)
            {
                source.UseSlotOneAbility(targets);
            }
        }

        public override int GetActionSpeed()
        {
            return source.CalculateSlotOneAbilityActionSpeed();
        }
    }
}