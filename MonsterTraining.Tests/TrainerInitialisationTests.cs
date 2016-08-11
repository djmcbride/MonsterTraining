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
            Player1.Monsters[0] = BuildMonster("Koromon","The in training version of Agumon.",Player1);

            Assert.AreEqual(Player1.Name, "Tai");
            Assert.AreEqual(Player1.Stats[StatList.Strength], 10);
            Assert.AreEqual(Player1.Affinities[AffinityList.Strength], 1);

            Assert.AreEqual(Player1.Monsters[0].Name, "Koromon");
            Assert.AreEqual(Player1.Monsters[0].Stats[StatList.Strength], 10);
            Assert.AreEqual(Player1.Monsters[0].Affinities[AffinityList.Strength], 1);
        }

        public Monster BuildMonster(string name, string description, Trainer assignedTrainer)
        {
            double[] trainingPoints = new double[StatList.ArrayLength];
            MakeTrainingPoints(trainingPoints);

            double[] affinities = new double[AffinityList.ArrayLength];
            MakeAffinities(affinities);

            double[] elementalMastery = new double[ElementList.ArrayLength];
            MakeElementalMastery(elementalMastery);

            Monster monster = new Monster(name, description, affinities, elementalMastery, trainingPoints, assignedTrainer);
            return monster;
        }

        public static Monster BuildMonster(string name, string description)
        {
            double[] trainingPoints = new double[StatList.ArrayLength];
            MakeTrainingPoints(trainingPoints);

            double[] affinities = new double[AffinityList.ArrayLength];
            MakeAffinities(affinities);

            double[] elementalMastery = new double[ElementList.ArrayLength];
            MakeElementalMastery(elementalMastery);

            Monster monster = new Monster(name, description, affinities, elementalMastery, trainingPoints);
            return monster;
        }


        public Trainer BuildTrainer(string name, string description)
        {
            double[] trainingPoints = new double[StatList.ArrayLength];
            MakeTrainingPoints(trainingPoints);

            double[] affinities = new double[AffinityList.ArrayLength];
            MakeAffinities(affinities);

            double[] elementalMastery = new double[ElementList.ArrayLength];
            MakeElementalMastery(elementalMastery);

            Trainer player = new Trainer(name, description, affinities, elementalMastery, trainingPoints);
            return player;
        }

        private static void MakeElementalMastery(double[] elementalMastery)
        {
            elementalMastery[ElementList.Air]           = 0;
            elementalMastery[ElementList.Balance]       = 0;
            elementalMastery[ElementList.Combustion]    = 0;
            elementalMastery[ElementList.Consumption]   = 0;
            elementalMastery[ElementList.Corrosion]     = 0;
            elementalMastery[ElementList.Dark]          = 0;
            elementalMastery[ElementList.Earth]         = 0;
            elementalMastery[ElementList.Fire]          = 0.2;
            elementalMastery[ElementList.Lava]          = 0;
            elementalMastery[ElementList.Life]          = 0;
            elementalMastery[ElementList.Light]         = 0;
            elementalMastery[ElementList.Lightning]     = 0;
            elementalMastery[ElementList.Metal]         = 0;
            elementalMastery[ElementList.Meteor]        = 0;
            elementalMastery[ElementList.Miasma]        = 0;
            elementalMastery[ElementList.Mist]          = 0;
            elementalMastery[ElementList.Oil]           = 0;
            elementalMastery[ElementList.Plasma]        = 0;
            elementalMastery[ElementList.Steam]         = 0;
            elementalMastery[ElementList.Water]         = 0;
            elementalMastery[ElementList.Wood]          = 0;
        }

        private static void MakeAffinities(double[] affinities)
        {
            affinities[AffinityList.Dark]         = 1;
            affinities[AffinityList.Earth]        = 1;
            affinities[AffinityList.Fire]         = 1;
            affinities[AffinityList.Light]        = 1;
            affinities[AffinityList.Wind]          = 1;
            affinities[AffinityList.Water]        = 1;
            affinities[AffinityList.Strength]     = 1;
            affinities[AffinityList.Vitality]     = 1;
            affinities[AffinityList.Agility]      = 1;
            affinities[AffinityList.Dexterity]    = 1;
            affinities[AffinityList.Mind]         = 1;
            affinities[AffinityList.Perception]   = 1;
        }

        private static void MakeTrainingPoints(double[] trainingPoints)
        {
            trainingPoints[StatList.SlashDefence]        = 10;
            trainingPoints[StatList.PiercingDefence]     = 10;
            trainingPoints[StatList.ImpactDefence]       = 10;
            trainingPoints[StatList.MeleeStrength]       = 10;
            trainingPoints[StatList.BlockStrength]       = 10;
            trainingPoints[StatList.MaxPhysicalStamina]  = 100;
            trainingPoints[StatList.MaxMentalStamina]    = 100;
            trainingPoints[StatList.MentalDefence]       = 10;
            trainingPoints[StatList.TopSpeed]            = 10;
            trainingPoints[StatList.Acceleration]        = 10;
            trainingPoints[StatList.AttackSpeed]         = 10;
            trainingPoints[StatList.MovementAccuracy]    = 10;
            trainingPoints[StatList.DodgeAbility]        = 10;
            trainingPoints[StatList.DamageConsistancy]   = 10;
            trainingPoints[StatList.TechniqueAccuracy]   = 10;
            trainingPoints[StatList.MentalStrength]      = 10;
            trainingPoints[StatList.TaughtLearning]      = 0;
            trainingPoints[StatList.NaturalLearning]     = 0;
            trainingPoints[StatList.PathFinding]         = 0;
            trainingPoints[StatList.PeripheralVision]    = 0;
            trainingPoints[StatList.MainVision]          = 0;
            trainingPoints[StatList.Hearing]             = 0;
            trainingPoints[StatList.PresenceSense]       = 0;
            trainingPoints[StatList.TargetSense]         = 0;
        }
    }
}
