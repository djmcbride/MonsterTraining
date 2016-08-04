using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MonsterTraining.Tests
{
    [TestClass]
    public class CharacterInitialisationTests
    {
        //START OF ENUM TESTS
        [TestMethod]
        public void CharacterBuildTestEnum()
        {
            
            for (int i = 0; i < 1000000; i++)
            {
                string name = "EnumMon" + Convert.ToString(i);
                string description = "Base level monster created to test the enum design";
                Dictionary<string, CharacterEnum> Player1 = new Dictionary<string, CharacterEnum>();
                int[] stats = new int[Enum.GetNames(typeof(EStats)).Length];
                MakeStatsEnum(stats);
                Player1.Add(name, new CharacterEnum(name, description, stats));
            }
        }

        private void MakeStatsEnum(int[] stats)
        {
            stats[(int)EStats.SlashDefence] = 0;
            stats[(int)EStats.PiercingDefence] = 0;
            stats[(int)EStats.ImpactDefence] = 0;
            stats[(int)EStats.LightningAffinity] = 0;
            stats[(int)EStats.WaterAffinity] = 0;
            stats[(int)EStats.WindAffinity] = 0;
            stats[(int)EStats.FireAffinity] = 0;
            stats[(int)EStats.EarthAffinity] = 0;
            stats[(int)EStats.LightAffinity] = 0;
            stats[(int)EStats.DarkAffinity] = 0;
            stats[(int)EStats.MeleeStrength] = 10;
            stats[(int)EStats.BlockStrength] = 10;
            stats[(int)EStats.MaxPhysicalStamina] = 100;
            stats[(int)EStats.MaxMentalStamina] = 100;
            stats[(int)EStats.PhysicalDefence] = 10;
            stats[(int)EStats.MentalDefence] = 10;
            stats[(int)EStats.TopSpeed] = 10;
            stats[(int)EStats.Acceleration] = 10;
            stats[(int)EStats.AttackSpeed] = 10;
            stats[(int)EStats.MovementAccuracy] = 10;
            stats[(int)EStats.DodgeAbility] = 10;
            stats[(int)EStats.DamageConsistancy] = 10;
            stats[(int)EStats.TechniqueAccuracy] = 10;
            stats[(int)EStats.MentalStrength] = 10;
            stats[(int)EStats.TaughtLearning] = 0;
            stats[(int)EStats.NaturalLearning] = 0;
            stats[(int)EStats.PathFinding] = 0;
            stats[(int)EStats.PeripheralVision] = 0;
            stats[(int)EStats.MainVision] = 0;
            stats[(int)EStats.Hearing] = 0;
            stats[(int)EStats.PresenceSense] = 0;
            stats[(int)EStats.TargetSense] = 0;
        }
        //END OF ENUM TESTS

        //START OF DICTIONARY TESTS
        [TestMethod]
        public void CharacterBuildTestDictionary()
        {
            for (int i = 0; i < 1000000; i++)
            {
                string name = "DictMon" + Convert.ToString(i);
                string description = "Base level monster created to test the dictionary design";
                Dictionary<string, CharacterDictionary> Player2 = new Dictionary<string, CharacterDictionary>();
                Dictionary<string, int> baseStats = MakeStatsDict();
                Player2.Add(name, new CharacterDictionary(name, description, baseStats));
            }
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
            baseStats.Add("MeleeStrength", 10);
            baseStats.Add("BlockStrength", 10);
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
        //END OF DICTIONARY TESTS

        //START OF CONSTANTS TESTS
        [TestMethod]
        public void CharacterBuildTestConstants()
        {
            for (int i = 0; i < 1000000; i++)
            {
                string name = "ConstMon" + Convert.ToString(i);
                string description = "Base level monster created to test the constant design";
                Dictionary<string, CharacterConstants> Player3 = new Dictionary<string, CharacterConstants>();

                int[] stats = new int[CharacterStats.ArrayLength];
                MakeStatsConstants(stats);
                Player3.Add(name, new CharacterConstants(name, description, stats));
            }
        }
        
        private void MakeStatsConstants(int[] stats)
        {
            stats[CharacterStats.SlashDefence] = 0;
            stats[CharacterStats.PiercingDefence] = 0;
            stats[CharacterStats.ImpactDefence] = 0;
            stats[CharacterStats.LightningAffinity] = 0;
            stats[CharacterStats.WaterAffinity] = 0;
            stats[CharacterStats.WindAffinity] = 0;
            stats[CharacterStats.FireAffinity] = 0;
            stats[CharacterStats.EarthAffinity] = 0;
            stats[CharacterStats.LightAffinity] = 0;
            stats[CharacterStats.DarkAffinity] = 0;
            stats[CharacterStats.MeleeStrength] = 10;
            stats[CharacterStats.BlockStrength] = 10;
            stats[CharacterStats.MaxPhysicalStamina] = 100;
            stats[CharacterStats.MaxMentalStamina] = 100;
            stats[CharacterStats.PhysicalDefence] = 10;
            stats[CharacterStats.MentalDefence] = 10;
            stats[CharacterStats.TopSpeed] = 10;
            stats[CharacterStats.Acceleration] = 10;
            stats[CharacterStats.AttackSpeed] = 10;
            stats[CharacterStats.MovementAccuracy] = 10;
            stats[CharacterStats.DodgeAbility] = 10;
            stats[CharacterStats.DamageConsistancy] = 10;
            stats[CharacterStats.TechniqueAccuracy] = 10;
            stats[CharacterStats.MentalStrength] = 10;
            stats[CharacterStats.TaughtLearning] = 0;
            stats[CharacterStats.NaturalLearning] = 0;
            stats[CharacterStats.PathFinding] = 0;
            stats[CharacterStats.PeripheralVision] = 0;
            stats[CharacterStats.MainVision] = 0;
            stats[CharacterStats.Hearing] = 0;
            stats[CharacterStats.PresenceSense] = 0;
            stats[CharacterStats.TargetSense] = 0;
        }
        //END OF CONSTANTS TESTS
    }
}
