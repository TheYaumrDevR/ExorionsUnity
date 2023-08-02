using System.Collections.Generic;

namespace Org.Ethasia.Evocri.Core
{
    public class BattleAbility
    {
        public int Damage
        {
            get;
            private set;
        }

        public BattleAbility(int damage)
        {
            Damage = damage;
        }

        public int CalculateActionSpeed(IndividualExorionStats sourceStats)
        {
            return sourceStats.AttackSpeed;
        }

        public void Use(List<IndividualExorion> enemies)
        {
            enemies.ForEach(enemy => enemy.ReceiveDamage(Damage));
        }
    }
}