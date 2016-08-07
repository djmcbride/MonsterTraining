using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTraining
{
    public class Character
    {
        //Constructor
        //public Character(string name, string description, Dictionary<string, int> leafStats) //DICTIONARY IMPLEMENTATION
        public Character(string name, string description, int[] baseStats)
        {
            Name = name;
            Description = description;
            Stats = baseStats;
            CalculateStats(Stats);
        }

        /*Fields*/
        public string Name;
        public string Description;
        //Gender;
        public int[] Stats;

        /*Subroutines*/
        public void UseTechnique(Technique technique)
        {

        }

        public void ReceiveTechnique(Technique technique)
        {

        }

        public void ReceiveStatusEffect(StatusEffect status)
        {

        }

        //Calculate Stats
        private void CalculateStats(int[] Stats)
        {
            Stats[StatList.Defence] = CalculateDefence(Stats[StatList.PhysicalDefence], Stats[StatList.MentalDefence]);
            Stats[StatList.Vision] = CalculateVision(Stats[StatList.PeripheralVision], Stats[StatList.MainVision]);
            Stats[StatList.Sense] = CalculateSense(Stats[StatList.PresenceSense], Stats[StatList.TargetSense]);
            Stats[StatList.LearningRate] = CalculateLearningRate(Stats[StatList.NaturalLearning], Stats[StatList.TaughtLearning]);
            Stats[StatList.Strength] = CalculateStrength(Stats[StatList.MeleeStrength], Stats[StatList.BlockStrength]);
            Stats[StatList.Vitality] = CalculateVitality(Stats[StatList.MaxMentalStamina], Stats[StatList.MaxPhysicalStamina], Stats[StatList.Defence]);
            Stats[StatList.Agility] = CalculateAgility(Stats[StatList.TopSpeed], Stats[StatList.Acceleration], Stats[StatList.AttackSpeed]);
            Stats[StatList.Dexterity] = CalculateDexterity(Stats[StatList.MovementAccuracy], Stats[StatList.DodgeAbility], Stats[StatList.DamageConsistancy], Stats[StatList.TechniqueAccuracy]);
            Stats[StatList.Perception] = CalculatePerception(Stats[StatList.Vision], Stats[StatList.Hearing], Stats[StatList.Strength]);
            Stats[StatList.Mind] = CalculateMind(Stats[StatList.MentalStrength], Stats[StatList.LearningRate], Stats[StatList.PathFinding]);
        }

        private int CalculateMind(int MentalStrength, int LearningRate, int PathFinding)
        {
            return (MentalStrength + LearningRate + PathFinding) / 3;
        }

        private int CalculatePerception(int Vision, int Hearing, int Sense)
        {
            return (Vision + Hearing + Sense) / 3;
        }

        private int CalculateDexterity(int MovementAccuracy, int DodgeAbility, int DamageConsistancy, int TechniqueAccuracy)
        {
            return (MovementAccuracy + DodgeAbility + DamageConsistancy + TechniqueAccuracy) / 4;
        }

        private int CalculateAgility(int TopSpeed, int Acceleration, int AttackSpeed)
        {
            return (TopSpeed + Acceleration + AttackSpeed) / 3;
        }

        private int CalculateVitality(int MaxMentalStamina, int MaxPhysicalStamina, int Defence)
        {
            return (MaxMentalStamina + MaxPhysicalStamina + Defence) / 3;
        }

        private int CalculateStrength(int MeleeStrength, int BlockStrength)
        {
            return (MeleeStrength + BlockStrength) / 2;
        }
        //Sub-Stat Calculations
        //Vitality
        private int CalculateDefence(int PhysicalDefence, int MentalDefence)
        {
            return (PhysicalDefence + MentalDefence) / 2;
        }

        //Perception
        private int CalculateVision(int PeripheralVision, int MainVision)
        {
            return (PeripheralVision + MainVision) / 2;
        }
        private int CalculateSense(int PresenceSense, int TargetSense)
        {
            return (PresenceSense + TargetSense) / 2;
        }

        //Mind
        protected int CalculateLearningRate(int TaughtLearning, int NaturalLearning)
        {
            return (TaughtLearning + NaturalLearning) / 2;
        }
    }
}
