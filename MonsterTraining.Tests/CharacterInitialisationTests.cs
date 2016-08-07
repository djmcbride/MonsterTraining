﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MonsterTraining.Tests
{
    [TestClass]
    public class CharacterInitialisationTests
    {
        [TestMethod]
        public void CharacterBuildBenchmark()
        {
            for (int i = 0; i < 1000000; i++)
            {
                BuildCharacter();
            }
        }

        [TestMethod]
        public void CharacterStatTest()
        {
            Dictionary<string, Character> Player1 = BuildCharacter();
            Assert.AreEqual(Player1["Koromon"].Stats[StatList.Strength], 10);
        }

        public Dictionary<string, Character> BuildCharacter()
        {
            string name = "Koromon";
            string description = "Base level monster";
            Dictionary<string, Character> Player1 = new Dictionary<string, Character>();

            int[] stats = new int[StatList.ArrayLength];
            MakeStats(stats);
            Player1.Add(name, new Character(name, description, stats));
            return Player1;
        }

        private void MakeStats(int[] stats)
        {
            stats[StatList.SlashDefence] = 0;
            stats[StatList.PiercingDefence] = 0;
            stats[StatList.ImpactDefence] = 0;
            stats[StatList.LightningAffinity] = 0;
            stats[StatList.WaterAffinity] = 0;
            stats[StatList.WindAffinity] = 0;
            stats[StatList.FireAffinity] = 0;
            stats[StatList.EarthAffinity] = 0;
            stats[StatList.LightAffinity] = 0;
            stats[StatList.DarkAffinity] = 0;
            stats[StatList.MeleeStrength] = 10;
            stats[StatList.BlockStrength] = 10;
            stats[StatList.MaxPhysicalStamina] = 100;
            stats[StatList.MaxMentalStamina] = 100;
            stats[StatList.PhysicalDefence] = 10;
            stats[StatList.MentalDefence] = 10;
            stats[StatList.TopSpeed] = 10;
            stats[StatList.Acceleration] = 10;
            stats[StatList.AttackSpeed] = 10;
            stats[StatList.MovementAccuracy] = 10;
            stats[StatList.DodgeAbility] = 10;
            stats[StatList.DamageConsistancy] = 10;
            stats[StatList.TechniqueAccuracy] = 10;
            stats[StatList.MentalStrength] = 10;
            stats[StatList.TaughtLearning] = 0;
            stats[StatList.NaturalLearning] = 0;
            stats[StatList.PathFinding] = 0;
            stats[StatList.PeripheralVision] = 0;
            stats[StatList.MainVision] = 0;
            stats[StatList.Hearing] = 0;
            stats[StatList.PresenceSense] = 0;
            stats[StatList.TargetSense] = 0;
        }
    }
}
