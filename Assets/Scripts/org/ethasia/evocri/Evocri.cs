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
            IndividualExorionStats exorionOneStats = new IndividualExorionStats
                .IndividualExorionStatsBuilder()
                .SetMaxHp(50)
                .SetCurrentHp(50)
                .SetAttackSpeed(120)
                .Build();

            IndividualExorionStats exorionTwoStats = new IndividualExorionStats
                .IndividualExorionStatsBuilder()
                .SetMaxHp(50)
                .SetCurrentHp(50)
                .SetAttackSpeed(170)
                .Build();                

            IndividualExorion enemyTeamOne = new IndividualExorion(exorionOneStats);
            IndividualExorion enemyTeamTwo = new IndividualExorion(exorionTwoStats);

            BattleAbility testAbilityOne = new BattleAbility(23);
            BattleAbility testAbilityTwo = new BattleAbility(15);

            enemyTeamOne.EquipAbilityOnSlotOne(testAbilityOne);
            enemyTeamTwo.EquipAbilityOnSlotOne(testAbilityTwo);

            List<IndividualExorion> teamOne = new List<IndividualExorion> { enemyTeamOne };
            List<IndividualExorion> teamTwo = new List<IndividualExorion> { enemyTeamTwo };

            UseBattleAbilityOnSlotOneCommand battleCommandTeamOne = new UseBattleAbilityOnSlotOneCommand(teamTwo, enemyTeamOne);
            UseBattleAbilityOnSlotOneCommand battleCommandTeamTwo = new UseBattleAbilityOnSlotOneCommand(teamOne, enemyTeamTwo);

            Battle testBattle = new Battle();
            testBattle.StartBattle(enemyTeamOne, enemyTeamTwo);

            testBattle.InputCommandTeamOne(battleCommandTeamOne);
            testBattle.InputCommandTeamTwo(battleCommandTeamTwo);
        }

        void Update()
        {
            
        }
    }
}