using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MonsterTraining.Tests
{
    [TestClass]
    public class CharacterTests
    {
        [TestMethod]
        public void MaxPhysicalStaminaGreaterThanZero()
        {
            Dictionary<string, Character> Player1 = CreatePlayer();
            Assert.IsTrue(Player1["Koromon"].Stats["MaxPhysicalStamina"] > 0);
        }

        private Dictionary<string, Character> CreatePlayer()
        {
            Dictionary<string, int> baseStats = MakeStatsDict();
            Dictionary<string, Character> Player1 = new Dictionary<string, Character>();
            Player1.Add("Koromon", new Character("Koromon", "Base level monster", baseStats));
            return Player1;
        }

        public Dictionary<string, int> MakeStatsDict()
        {
            Dictionary<string, int> baseStats = new Dictionary<string, int>();
            baseStats.Add("SlashDefence", 0);
            baseStats.Add("PiercingDefence", 0);
            baseStats.Add("ImpactDefence", 0);
            baseStats.Add("LightningAffinity", 0);
            baseStats.Add("WaterAffinity", 0);
            baseStats.Add("WindAffinity", 0);
            baseStats.Add("FireAffinity", 0);
            baseStats.Add("EarthAffinity", 0);
            baseStats.Add("LightAffinity", 0);
            baseStats.Add("DarkAffinity", 0);
            baseStats.Add("MeleeStrength", 0);
            baseStats.Add("BlockStrength", 0);
            baseStats.Add("MaxPhysicalStamina", 100);
            baseStats.Add("MaxMentalStamina", 100);
            baseStats.Add("PhysicalDefence", 10);
            baseStats.Add("MentalDefence", 10);
            baseStats.Add("TopSpeed", 10);
            baseStats.Add("Acceleration", 10);
            baseStats.Add("AttackSpeed", 10);
            baseStats.Add("MovementAccuracy", 10);
            baseStats.Add("DodgeAbility", 10);
            baseStats.Add("DamageConsistancy", 10);
            baseStats.Add("TechniqueAccuracy", 10);
            baseStats.Add("MentalStrength", 10);
            baseStats.Add("TaughtLearning", 0);
            baseStats.Add("NaturalLearning", 0);
            baseStats.Add("PathFinding", 0);
            baseStats.Add("PeripheralVision", 0);
            baseStats.Add("MainVision", 0);
            baseStats.Add("Hearing", 0);
            baseStats.Add("PresenceSense", 0);
            baseStats.Add("TargetSense", 0);
            return baseStats;
        }
    }
}
