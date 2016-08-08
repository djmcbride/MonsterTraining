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
        public Character(string name, string description, int[] affinities, int[] trainingPoints)
        {
            Name = name;
            Description = description;
            Affinities = affinities;
            TrainingPoints = trainingPoints;
            Stats = new int[StatList.ArrayLength];
            UpdateStats();
        }


        /*Fields*/
        public string Name { get; set; }
        public string Description { get; set; }
        public int[] Affinities { get; set; }
        private int[] TrainingPoints { get; set; }
        public int[] Stats { get; set; }

        //Gender;
        

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

        //Stat calculations
        private void UpdateStats()
        {
            ConvertTrainingPointsToStats();
            CalculateStats(Stats);
        }

        private void ConvertTrainingPointsToStats()
        {
            //This method takes the training points, multiplies them by the affinity level for the relevant stat category, and then applies the result to the stat field
            int vitalityAffinity = Affinities[AffinityList.Vitality];
            Stats[StatList.SlashDefence] = TrainingPoints[StatList.SlashDefence] * vitalityAffinity;
            Stats[StatList.PiercingDefence] = TrainingPoints[StatList.PiercingDefence] * vitalityAffinity;
            Stats[StatList.ImpactDefence] = TrainingPoints[StatList.ImpactDefence] * vitalityAffinity;
            Stats[StatList.MaxPhysicalStamina] = TrainingPoints[StatList.MaxPhysicalStamina] * vitalityAffinity;
            Stats[StatList.MaxMentalStamina] = TrainingPoints[StatList.MaxMentalStamina] * vitalityAffinity;
            Stats[StatList.PhysicalDefence] = TrainingPoints[StatList.PhysicalDefence] * vitalityAffinity;
            Stats[StatList.MentalDefence] = TrainingPoints[StatList.MentalDefence] * vitalityAffinity;

            int strengthAffinity = Affinities[AffinityList.Strength];
            Stats[StatList.MeleeStrength] = TrainingPoints[StatList.MeleeStrength] * strengthAffinity;
            Stats[StatList.BlockStrength] = TrainingPoints[StatList.BlockStrength] * strengthAffinity;

            int agilityAffinity = Affinities[AffinityList.Agility];
            Stats[StatList.TopSpeed] = TrainingPoints[StatList.TopSpeed] * agilityAffinity;
            Stats[StatList.Acceleration] = TrainingPoints[StatList.Acceleration] * agilityAffinity;
            Stats[StatList.AttackSpeed] = TrainingPoints[StatList.AttackSpeed] * agilityAffinity;

            int dexterityAffinity = Affinities[AffinityList.Dexterity];
            Stats[StatList.MovementAccuracy] = TrainingPoints[StatList.MovementAccuracy] * dexterityAffinity;
            Stats[StatList.DodgeAbility] = TrainingPoints[StatList.DodgeAbility] * dexterityAffinity;
            Stats[StatList.DamageConsistancy] = TrainingPoints[StatList.DamageConsistancy] * dexterityAffinity;
            Stats[StatList.TechniqueAccuracy] = TrainingPoints[StatList.TechniqueAccuracy] * dexterityAffinity;

            int mindAffinity = Affinities[AffinityList.Mind];
            Stats[StatList.MentalStrength] = TrainingPoints[StatList.MentalStrength] * mindAffinity;
            Stats[StatList.TaughtLearning] = TrainingPoints[StatList.TaughtLearning] * mindAffinity;
            Stats[StatList.NaturalLearning] = TrainingPoints[StatList.NaturalLearning] * mindAffinity;
            Stats[StatList.PathFinding] = TrainingPoints[StatList.PathFinding] * mindAffinity;

            int perceptionAffinity = Affinities[AffinityList.Perception];
            Stats[StatList.PeripheralVision] = TrainingPoints[StatList.PeripheralVision] * perceptionAffinity;
            Stats[StatList.MainVision] = TrainingPoints[StatList.MainVision] * perceptionAffinity;
            Stats[StatList.Hearing] = TrainingPoints[StatList.Hearing] * perceptionAffinity;
            Stats[StatList.PresenceSense] = TrainingPoints[StatList.PresenceSense] * perceptionAffinity;
            Stats[StatList.TargetSense] = TrainingPoints[StatList.TargetSense] * perceptionAffinity;
        }

        private void CalculateStats(int[] Stats)
        {   
            /*This method calculates the stats by utilising stats that can be trained directly (i.e. those that don't depend on other stats)
             * The order in which the stats are calculated is based on tiers of dependency
             */

            //Tier 3 - This stat category has dependents within tier 2
            Stats[StatList.PhysicalDefence] = CalculatePhysicalDefence(Stats[StatList.ImpactDefence], Stats[StatList.PiercingDefence], Stats[StatList.SlashDefence]);
            
            //Tier 2 - These stats have dependents in tier 1
            Stats[StatList.Defence] = CalculateDefence(Stats[StatList.PhysicalDefence], Stats[StatList.MentalDefence]);
            Stats[StatList.Vision] = CalculateVision(Stats[StatList.PeripheralVision], Stats[StatList.MainVision]);
            Stats[StatList.Sense] = CalculateSense(Stats[StatList.PresenceSense], Stats[StatList.TargetSense]);
            Stats[StatList.LearningRate] = CalculateLearningRate(Stats[StatList.NaturalLearning], Stats[StatList.TaughtLearning]);
            
            //Tier 1 - Root Nodes - These base stats are the main stats that the user sees
            Stats[StatList.Strength] = CalculateStrength(Stats[StatList.MeleeStrength], Stats[StatList.BlockStrength]);
            Stats[StatList.Vitality] = CalculateVitality(Stats[StatList.MaxMentalStamina], Stats[StatList.MaxPhysicalStamina], Stats[StatList.Defence]);
            Stats[StatList.Agility] = CalculateAgility(Stats[StatList.TopSpeed], Stats[StatList.Acceleration], Stats[StatList.AttackSpeed]);
            Stats[StatList.Dexterity] = CalculateDexterity(Stats[StatList.MovementAccuracy], Stats[StatList.DodgeAbility], Stats[StatList.DamageConsistancy], Stats[StatList.TechniqueAccuracy]);
            Stats[StatList.Perception] = CalculatePerception(Stats[StatList.Vision], Stats[StatList.Hearing], Stats[StatList.Sense]);
            Stats[StatList.Mind] = CalculateMind(Stats[StatList.MentalStrength], Stats[StatList.LearningRate], Stats[StatList.PathFinding]);
            
            /*Tier 0 - Peripheral Stats - This stat category leverages multiple tier 1 stats.  
             * The relationship between tiers 0 and 1 is farther removed than the others as
             * tier 0 has no bearing on tier 1.*/
            //Critical chance is based off of two base stats (dexterity and perception)
            Stats[StatList.CriticalHitChance] = CalculateCriticalHitChance(Stats[StatList.Dexterity], Stats[StatList.Perception]);
        }

        private int CalculateCriticalHitChance(int dexterity, int perception)
        {
            //The base chance to score a critical hit with any technique
            int initialCalc = (20 + dexterity + perception) / 2;
            return initialCalc / 4;
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

        private int CalculatePhysicalDefence(int impact, int piercing, int slash)
        {
            return (impact + piercing + slash) / 3;
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
