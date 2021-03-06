﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTraining
{
    public class Character
    {
        /*Fields*/
        public string Name { get; set; }
        public string Description { get; set; }
        public double[] Affinities { get; set; }
        public double[] TrainingPoints { get; set; }
        public double[] Stats { get; set; }
        public double[] ElementalMastery { get; set; }

        //Haven't implemented yet
        //Gender; 
        //Weight;

        /*Constructor*/
        public Character(string name, string description, double[] affinities, double[] elementalMastery, double[] trainingPoints)
        {
            Name = name;
            Description = description;
            Affinities = affinities;
            CalculateElementalAffinities();
            TrainingPoints = trainingPoints;
            Stats = new double[StatList.ArrayLength];
            UpdateStats();
        }





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


        //Affinity Calculations
        private void CalculateElementalAffinities()
        {
            //Each sub-affinity is only as strong as its weakest component
            Affinities[AffinityList.Wood] = FindLowest(Affinities[AffinityList.Earth], Affinities[AffinityList.Water]);
            Affinities[AffinityList.Lava] = FindLowest(Affinities[AffinityList.Earth], Affinities[AffinityList.Fire]);
            Affinities[AffinityList.Meteor] = FindLowest(Affinities[AffinityList.Earth], Affinities[AffinityList.Wind]);
            Affinities[AffinityList.Metal] = FindLowest(Affinities[AffinityList.Earth], Affinities[AffinityList.Light]);
            Affinities[AffinityList.Oil] = FindLowest(Affinities[AffinityList.Earth], Affinities[AffinityList.Dark]);
            Affinities[AffinityList.Steam] = FindLowest(Affinities[AffinityList.Water], Affinities[AffinityList.Fire]);
            Affinities[AffinityList.Mist] = FindLowest(Affinities[AffinityList.Water], Affinities[AffinityList.Wind]);
            Affinities[AffinityList.Life] = FindLowest(Affinities[AffinityList.Water], Affinities[AffinityList.Light]);
            Affinities[AffinityList.Corrosion] = FindLowest(Affinities[AffinityList.Water], Affinities[AffinityList.Dark]);
            Affinities[AffinityList.Combustion] = FindLowest(Affinities[AffinityList.Fire], Affinities[AffinityList.Wind]);
            Affinities[AffinityList.Plasma] = FindLowest(Affinities[AffinityList.Fire], Affinities[AffinityList.Light]);
            Affinities[AffinityList.Consumption] = FindLowest(Affinities[AffinityList.Fire], Affinities[AffinityList.Dark]);
            Affinities[AffinityList.Lightning] = FindLowest(Affinities[AffinityList.Wind], Affinities[AffinityList.Light]);
            Affinities[AffinityList.Miasma] = FindLowest(Affinities[AffinityList.Wind], Affinities[AffinityList.Dark]);
            Affinities[AffinityList.Balance] = FindLowest(Affinities[AffinityList.Light], Affinities[AffinityList.Dark]);
        }

        //returns the lowest number
        private double FindLowest(double num1, double num2)
        {
            return (num1 < num2) ? num1 : num2; //This works just like an if else statement.
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
            double vitalityAffinity = Affinities[AffinityList.Vitality];
            Stats[StatList.SlashDefence] = TrainingPoints[StatList.SlashDefence] * vitalityAffinity;
            Stats[StatList.PiercingDefence] = TrainingPoints[StatList.PiercingDefence] * vitalityAffinity;
            Stats[StatList.ImpactDefence] = TrainingPoints[StatList.ImpactDefence] * vitalityAffinity;
            Stats[StatList.MaxPhysicalStamina] = TrainingPoints[StatList.MaxPhysicalStamina] * vitalityAffinity;
            Stats[StatList.MaxMentalStamina] = TrainingPoints[StatList.MaxMentalStamina] * vitalityAffinity;
            Stats[StatList.PhysicalDefence] = TrainingPoints[StatList.PhysicalDefence] * vitalityAffinity;
            Stats[StatList.MentalDefence] = TrainingPoints[StatList.MentalDefence] * vitalityAffinity;

            double strengthAffinity = Affinities[AffinityList.Strength];
            Stats[StatList.MeleeStrength] = TrainingPoints[StatList.MeleeStrength] * strengthAffinity;
            Stats[StatList.BlockStrength] = TrainingPoints[StatList.BlockStrength] * strengthAffinity;

            double agilityAffinity = Affinities[AffinityList.Agility];
            Stats[StatList.TopSpeed] = TrainingPoints[StatList.TopSpeed] * agilityAffinity;
            Stats[StatList.Acceleration] = TrainingPoints[StatList.Acceleration] * agilityAffinity;
            Stats[StatList.AttackSpeed] = TrainingPoints[StatList.AttackSpeed] * agilityAffinity;

            double dexterityAffinity = Affinities[AffinityList.Dexterity];
            Stats[StatList.MovementAccuracy] = TrainingPoints[StatList.MovementAccuracy] * dexterityAffinity;
            Stats[StatList.DodgeAbility] = TrainingPoints[StatList.DodgeAbility] * dexterityAffinity;
            Stats[StatList.DamageConsistancy] = TrainingPoints[StatList.DamageConsistancy] * dexterityAffinity;
            Stats[StatList.TechniqueAccuracy] = TrainingPoints[StatList.TechniqueAccuracy] * dexterityAffinity;

            double mindAffinity = Affinities[AffinityList.Mind];
            Stats[StatList.MentalStrength] = TrainingPoints[StatList.MentalStrength] * mindAffinity;
            Stats[StatList.TaughtLearning] = TrainingPoints[StatList.TaughtLearning] * mindAffinity;
            Stats[StatList.NaturalLearning] = TrainingPoints[StatList.NaturalLearning] * mindAffinity;
            Stats[StatList.PathFinding] = TrainingPoints[StatList.PathFinding] * mindAffinity;

            double perceptionAffinity = Affinities[AffinityList.Perception];
            Stats[StatList.PeripheralVision] = TrainingPoints[StatList.PeripheralVision] * perceptionAffinity;
            Stats[StatList.MainVision] = TrainingPoints[StatList.MainVision] * perceptionAffinity;
            Stats[StatList.Hearing] = TrainingPoints[StatList.Hearing] * perceptionAffinity;
            Stats[StatList.PresenceSense] = TrainingPoints[StatList.PresenceSense] * perceptionAffinity;
            Stats[StatList.TargetSense] = TrainingPoints[StatList.TargetSense] * perceptionAffinity;
        }

        private void CalculateStats(double[] Stats)
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

        private double CalculateCriticalHitChance(double dexterity, double perception)
        {
            //The base chance to score a critical hit with any technique
            double initialCalc = (20 + dexterity + perception) / 2;
            return initialCalc / 4;
        }

        private double CalculateMind(double MentalStrength, double LearningRate, double PathFinding)
        {
            return (MentalStrength + LearningRate + PathFinding) / 3;
        }

        private double CalculatePerception(double Vision, double Hearing, double Sense)
        {
            return (Vision + Hearing + Sense) / 3;
        }

        private double CalculateDexterity(double MovementAccuracy, double DodgeAbility, double DamageConsistancy, double TechniqueAccuracy)
        {
            return (MovementAccuracy + DodgeAbility + DamageConsistancy + TechniqueAccuracy) / 4;
        }

        private double CalculateAgility(double TopSpeed, double Acceleration, double AttackSpeed)
        {
            return (TopSpeed + Acceleration + AttackSpeed) / 3;
        }

        private double CalculateVitality(double MaxMentalStamina, double MaxPhysicalStamina, double Defence)
        {
            return (MaxMentalStamina + MaxPhysicalStamina + Defence) / 3;
        }

        private double CalculateStrength(double MeleeStrength, double BlockStrength)
        {
            return (MeleeStrength + BlockStrength) / 2;
        }

        private double CalculatePhysicalDefence(double impact, double piercing, double slash)
        {
            return (impact + piercing + slash) / 3;
        }

        //Sub-Stat Calculations
        //Vitality
        private double CalculateDefence(double PhysicalDefence, double MentalDefence)
        {
            return (PhysicalDefence + MentalDefence) / 2;
        }

        //Perception
        private double CalculateVision(double PeripheralVision, double MainVision)
        {
            return (PeripheralVision + MainVision) / 2;
        }
        private double CalculateSense(double PresenceSense, double TargetSense)
        {
            return (PresenceSense + TargetSense) / 2;
        }

        //Mind
        protected double CalculateLearningRate(double TaughtLearning, double NaturalLearning)
        {
            return (TaughtLearning + NaturalLearning) / 2;
        }
    }
}
