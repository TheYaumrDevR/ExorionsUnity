using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Org.Ethasia.Evocri.Core;

namespace Org.Ethasia.Evocri
{
    public class Evocri : MonoBehaviour
    {

        void Start()
        {
            IndividualExorion enemyTeamOne = new IndividualExorion();
            IndividualExorion enemyTeamTwo = new IndividualExorion();

            enemyTeamOne.AttackSpeed = 120;
            enemyTeamTwo.AttackSpeed = 170;

            BattleAbility testAbilityOne = new BattleAbility(23);
            BattleAbility testAbilityTwo = new BattleAbility(15);

            enemyTeamOne.EquipAbilityOnSlotOne(testAbilityOne);
            enemyTeamTwo.EquipAbilityOnSlotOne(testAbilityTwo);

            Battle testBattle = new Battle();
            testBattle.StartBattle(enemyTeamOne, enemyTeamTwo);
        }

        void Update()
        {
            
        }
    }
}