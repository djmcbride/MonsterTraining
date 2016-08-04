using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTraining
{
    public class CharacterEnum
    {
        //Constructor
        //public Character(string name, string description, Dictionary<string, int> leafStats) //DICTIONARY IMPLEMENTATION
        public CharacterEnum(string name, string description, int[] baseStats)
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
            Stats[(int)EStats.Defence] = CalculateDefence(Stats[(int)EStats.PhysicalDefence], Stats[(int)EStats.MentalDefence]);
            Stats[(int)EStats.Vision] = CalculateVision(Stats[(int)EStats.PeripheralVision], Stats[(int)EStats.MainVision]);
            Stats[(int)EStats.Sense] = CalculateSense(Stats[(int)EStats.PresenceSense], Stats[(int)EStats.TargetSense]);
            Stats[(int)EStats.LearningRate] = CalculateLearningRate(Stats[(int)EStats.NaturalLearning], Stats[(int)EStats.TaughtLearning]);
            Stats[(int)EStats.Strength] = CalculateStrength(Stats[(int)EStats.MeleeStrength], Stats[(int)EStats.BlockStrength]);
            Stats[(int)EStats.Vitality] = CalculateVitality(Stats[(int)EStats.MaxMentalStamina], Stats[(int)EStats.MaxPhysicalStamina], Stats[(int)EStats.Defence]);
            Stats[(int)EStats.Agility] = CalculateAgility(Stats[(int)EStats.TopSpeed], Stats[(int)EStats.Acceleration], Stats[(int)EStats.AttackSpeed]);
            Stats[(int)EStats.Dexterity] = CalculateDexterity(Stats[(int)EStats.MovementAccuracy], Stats[(int)EStats.DodgeAbility], Stats[(int)EStats.DamageConsistancy], Stats[(int)EStats.TechniqueAccuracy]);
            Stats[(int)EStats.Perception] = CalculatePerception(Stats[(int)EStats.Vision], Stats[(int)EStats.Hearing], Stats[(int)EStats.Strength]);
            Stats[(int)EStats.Mind] = CalculateMind(Stats[(int)EStats.MentalStrength], Stats[(int)EStats.LearningRate], Stats[(int)EStats.PathFinding]);
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
