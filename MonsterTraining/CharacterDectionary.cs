using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTraining
{
    public class CharacterDictionary
    {
        //Constructor
        public CharacterDictionary(string name, string description, Dictionary<string, int> baseStats)
        {
            Name = name;
            Description = description;
            Stats = new Dictionary<string, int>(baseStats);

            //Calculates branch stats based off of leaf stats
            Stats.Add("Defence", CalculateDefence(Stats["PhysicalDefence"], Stats["MentalDefence"]));
            Stats.Add("Vision", CalculateVision(Stats["PeripheralVision"], Stats["MainVision"]));
            Stats.Add("Sense", CalculateSense(Stats["PresenceSense"], Stats["TargetSense"]));
            Stats.Add("LearningRate", CalculateLearningRate(Stats["TaughtLearning"], Stats["NaturalLearning"]));

            //Calculates root stats based off of leaf stats and branch stats
            Stats.Add("Strength", CalculateStrength(Stats["MeleeStrength"], Stats["BlockStrength"]));
            Stats.Add("Vitality", CalculateVitality(Stats["MaxMentalStamina"], Stats["MaxPhysicalStamina"], Stats["Defence"]));
            Stats.Add("Agility", CalculateAgility(Stats["TopSpeed"], Stats["Acceleration"], Stats["AttackSpeed"]));
            Stats.Add("Dexterity", CalculateDexterity(Stats["MovementAccuracy"], Stats["DodgeAbility"], Stats["DamageConsistancy"], Stats["TechniqueAccuracy"]));
            Stats.Add("Perception", CalculatePerception(Stats["Vision"], Stats["Hearing"], Stats["Sense"]));
            Stats.Add("Mind", CalculateMind(Stats["MentalStrength"], Stats["LearningRate"], Stats["PathFinding"]));

        }

        

        /*Fields*/
        //details
        public string Name;
        public string Description;
        //Gender;
        public Dictionary<string, int> Stats; //DICTIONARY IMPLEMENTATION

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
