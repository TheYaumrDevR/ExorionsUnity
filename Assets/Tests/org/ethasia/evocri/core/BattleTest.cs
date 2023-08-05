using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;

using Org.Ethasia.Evocri.Core;

namespace Org.Ethasia.Evocri.Core
{
    public class BattleTest
    {
        [Test]
        public void TestBattleAbilityDealsDamage()
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

            StartBattleWithStats(exorionOneStats, exorionTwoStats);  

            int exorionOneHp = exorionOneStats.CurrentHp;
            int exorionTwoHp = exorionTwoStats.CurrentHp;

            Assert.That(exorionOneHp, Is.EqualTo(35));   
            Assert.That(exorionTwoHp, Is.EqualTo(27)); 
        }

        [Test]
        public void TestBattleFasterExorionAttacksFirst()
        {
            IndividualExorionStats exorionOneStats = new IndividualExorionStats
                .IndividualExorionStatsBuilder()
                .SetMaxHp(50)
                .SetCurrentHp(10)
                .SetAttackSpeed(120)
                .Build();

            IndividualExorionStats exorionTwoStats = new IndividualExorionStats
                .IndividualExorionStatsBuilder()
                .SetMaxHp(50)
                .SetCurrentHp(50)
                .SetAttackSpeed(170)
                .Build();                

            StartBattleWithStats(exorionOneStats, exorionTwoStats);  

            int exorionOneHp = exorionOneStats.CurrentHp;
            int exorionTwoHp = exorionTwoStats.CurrentHp;

            Assert.That(exorionOneHp, Is.EqualTo(0));   
            Assert.That(exorionTwoHp, Is.EqualTo(50)); 
        }


        private void StartBattleWithStats(IndividualExorionStats exorionOneStats, IndividualExorionStats exorionTwoStats)
        {
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
    }
}