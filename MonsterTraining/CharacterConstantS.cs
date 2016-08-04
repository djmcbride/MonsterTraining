using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTraining
{
    public class CharacterConstants
    {
        //Constructor
        //public Character(string name, string description, Dictionary<string, int> leafStats) //DICTIONARY IMPLEMENTATION
        public CharacterConstants(string name, string description, int[] baseStats)
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
            Stats[CharacterStats.Defence] = CalculateDefence(Stats[CharacterStats.PhysicalDefence], Stats[CharacterStats.MentalDefence]);
            Stats[CharacterStats.Vision] = CalculateVision(Stats[CharacterStats.PeripheralVision], Stats[CharacterStats.MainVision]);
            Stats[CharacterStats.Sense] = CalculateSense(Stats[CharacterStats.PresenceSense], Stats[CharacterStats.TargetSense]);
            Stats[CharacterStats.LearningRate] = CalculateLearningRate(Stats[CharacterStats.NaturalLearning], Stats[CharacterStats.TaughtLearning]);
            Stats[CharacterStats.Strength] = CalculateStrength(Stats[CharacterStats.MeleeStrength], Stats[CharacterStats.BlockStrength]);
            Stats[CharacterStats.Vitality] = CalculateVitality(Stats[CharacterStats.MaxMentalStamina], Stats[CharacterStats.MaxPhysicalStamina], Stats[CharacterStats.Defence]);
            Stats[CharacterStats.Agility] = CalculateAgility(Stats[CharacterStats.TopSpeed], Stats[CharacterStats.Acceleration], Stats[CharacterStats.AttackSpeed]);
            Stats[CharacterStats.Dexterity] = CalculateDexterity(Stats[CharacterStats.MovementAccuracy], Stats[CharacterStats.DodgeAbility], Stats[CharacterStats.DamageConsistancy], Stats[CharacterStats.TechniqueAccuracy]);
            Stats[CharacterStats.Perception] = CalculatePerception(Stats[CharacterStats.Vision], Stats[CharacterStats.Hearing], Stats[CharacterStats.Strength]);
            Stats[CharacterStats.Mind] = CalculateMind(Stats[CharacterStats.MentalStrength], Stats[CharacterStats.LearningRate], Stats[CharacterStats.PathFinding]);
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
