using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MonsterTraining.Tests
{
    [TestClass]
    public class TrainerInitialisationTests
    {
        [TestMethod]
        public void TrainerStatTest()
        {
            Trainer Player1 = BuildTrainer("Tai", "The unofficial leader of the Digidestined");
            Player1.Monsters[0] = buildMonster("Koromon","The in training version of Agumon.",Player1);
            Assert.AreEqual(Player1.Stats[StatList.Defence], 10);
            Assert.AreEqual(Player1.Monsters[0].Name, "Koromon");
        }

        private Monster buildMonster(string name, string description, Trainer assignedTrainer)
        {
            int[] stats = new int[StatList.ArrayLength];
            MakeStats(stats);
            Monster monster = new Monster(name, description, stats, assignedTrainer);
            return monster;
        }


        public Trainer BuildTrainer(string name, string description)
        {
            int[] stats = new int[StatList.ArrayLength];
            MakeStats(stats);
            Trainer player = new Trainer(name, description, stats);
            return player;
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
