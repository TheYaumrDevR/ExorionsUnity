using System.Collections.Generic;

namespace Org.Ethasia.Evocri.Core
{
    public class BattleAbility
    {
        public int Damage
        {
            get;
        }

        public BattleAbility(int damage)
        {
            Damage = damage;
        }

        public void Use(List<IndividualExorion> enemies)
        {
            enemies.ForEach(enemy => enemy.ReceiveDamage(Damage));
        }
    }
}