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