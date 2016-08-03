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
        public Character(string name, string description, Dictionary<string, int> leafStats)
        {
            Name = name;
            Description = description;
            Stats = new Dictionary<string, int>(leafStats);

            //Calculates branch stats based off of leaf stats
            Stats.Add("Defence", CalculateDefence(Stats["PhysicalDefence"], Stats["MentalDefence"]));
            Stats.Add("Vision",CalculateVision(Stats["PeripheralVision"], Stats["MainVision"]));
            Stats.Add("Sense", CalculateSense(Stats["PresenceSense"], Stats["TargetSense"]));
            Stats.Add("LearningRate", CalculateLearningRate(Stats["TaughtLearning"], Stats["NaturalLearning"]));

            //Calculates root stats based off of leaf stats and branch stats
            Stats.Add("Strength",CalculateStrength(Stats["MeleeStrength"],Stats["BlockStrength"]));
            Stats.Add("Vitality",CalculateVitality(Stats["MaxMentalStamina"],Stats["MaxPhysicalStamina"],Stats["Defence"]));
            Stats.Add("Agility",CalculateAgility(Stats["TopSpeed"], Stats["Acceleration"], Stats["AttackSpeed"]));
            Stats.Add("Dexterity",CalculateDexterity(Stats["MovementAccuracy"],Stats["DodgeAbility"],Stats["DamageConsistancy"],Stats["TechniqueAccuracy"]));
            Stats.Add("Perception", CalculatePerception(Stats["Vision"], Stats["Hearing"], Stats["Sense"]));
            Stats.Add("Mind", CalculateMind(Stats["MentalStrength"], Stats["LearningRate"], Stats["PathFinding"]));

            /*MANUAL IMPLEMENTATION
            //The code below uses the values in the dictionary to set the base stats so that CalculateStats() can run.
            SlashDefence = baseStats["SlashDefence"];
            PiercingDefence = baseStats["PiercingDefence"];
            ImpactDefence = baseStats["ImpactDefence"];
            LightningAffinity = baseStats["LightningAffinity"];
            WaterAffinity = baseStats["WaterAffinity"];
            WindAffinity = baseStats["WindAffinity"];
            FireAffinity = baseStats["FireAffinity"];
            EarthAffinity = baseStats["EarthAffinity"];
            LightAffinity = baseStats["LightAffinity"];
            DarkAffinity = baseStats["DarkAffinity"];
            MeleeStrength = baseStats["MeleeStrength"];
            BlockStrength = baseStats["BlockStrength"];
            MaxPhysicalStamina = baseStats["MaxPhysicalStamina"];
            MaxMentalStamina = baseStats["MaxMentalStamina"];
            CurrentMentalStamina = baseStats["CurrentMentalStamina"];
            CurrentPhysicalStamina = baseStats["CurrentPhysicalStamina"];
            PhysicalDefence = baseStats["PhysicalDefence"];
            MentalDefence = baseStats["MentalDefence"];
            TopSpeed = baseStats["TopSpeed"];
            Acceleration = baseStats["Acceleration"];
            AttackSpeed = baseStats["AttackSpeed"];
            MovementAccuracy = baseStats["MovementAccuracy"];
            DodgeAbility = baseStats["DodgeAbility"];
            DamageConsistancy = baseStats["DamageConsistancy"];
            TechniqueAccuracy = baseStats["TechniqueAccuracy"];
            MentalStrength = baseStats["MentalStrength"];
            TaughtLearning = baseStats["TaughtLearning"];
            NaturalLearning = baseStats["NaturalLearning"];
            PathFinding = baseStats["PathFinding"];
            PeripheralVision = baseStats["PeripheralVision"];
            MainVision = baseStats["MainVision"];
            Hearing = baseStats["Hearing"];
            PresenceSense = baseStats["PresenceSense"];
            TargetSense = baseStats["TargetSense"];

            //Uses the newly set base classes to calculate the stats overall
            CalculateStats();
            */
        }

        public Dictionary<string, int> Stats;
        
        /*Variables*/
        //details
        public string Name;
        public string Description;
        //Gender;

        /*MANUAL IMPLEMENTATION
        //Resistance to different damage types
        protected int SlashDefence;
        protected int PiercingDefence;
        protected int ImpactDefence;

        //Affinity to different element types
        protected int LightningAffinity;
        protected int WaterAffinity;
        protected int WindAffinity;
        protected int FireAffinity;
        protected int EarthAffinity;
        protected int LightAffinity;
        protected int DarkAffinity;

        //Stats: split by category, as per game design
        //Main Stat
        protected int Strength;
        //sub-stats
        protected int MeleeStrength;
        protected int BlockStrength;

        //Main Stat
        protected int Vitality;
        //sub-stats
        protected int MaxPhysicalStamina;
        protected int MaxMentalStamina;
        protected int CurrentMentalStamina;
        protected int CurrentPhysicalStamina;
        protected int Defence;
        protected int PhysicalDefence;   //Defence sub-stat
        protected int MentalDefence;     //Defence sub-stat

        //Main Stat
        protected int Agility;
        //sub-stats
        protected int TopSpeed;
        protected int Acceleration;
        protected int AttackSpeed;

        //Main Stat
        protected int Dexterity;
        //sub-stats
        protected int MovementAccuracy;
        protected int DodgeAbility;
        protected int DamageConsistancy;
        protected int TechniqueAccuracy;

        //Main Stat
        protected int Mind;
        //sub-stats
        protected int MentalStrength;
        protected int LearningRate;
        protected int TaughtLearning;    //LearningRate sub-stat
        protected int NaturalLearning;   //LearningRate sub-stat
        protected int PathFinding;

        //Main Stat
        protected int Perception;
        //sub-stats
        protected int Vision;
        protected int PeripheralVision;  //Vision sub-stat
        protected int MainVision;        //Vision sub-stat
        protected int Hearing;
        protected int Sense;
        protected int PresenceSense;     //Sense sub-stat
        protected int TargetSense;       //Sense sub-stat
        */


        /*Subroutines*/
        public void UseTechnique(Technique technique)
        {

        }

        public void ReceiveTechnique(Technique technique)
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

/*MANUAL IMPLEMENTATION
        protected void CalculateStats()
        {
            CalculateStrength();
            CalculateVitality();
            CalculateAgility();
            CalculateDexterity();
            CalculatePerception();
            CalculateMind();
        }
protected void CalculateStrength()
{
   Strength = (MeleeStrength + BlockStrength) / 2;
}
protected void CalculateVitality()
{
   CalculateDefence();
   Vitality = (MaxMentalStamina + MaxPhysicalStamina + Defence) / 3;
}
protected void CalculateAgility()
{
   Agility = (TopSpeed + Acceleration + AttackSpeed) / 3;
}
protected void CalculateDexterity()
{
   Dexterity = (MovementAccuracy + DodgeAbility + DamageConsistancy + TechniqueAccuracy) / 4;
}
protected void CalculatePerception()
{
   CalculateVision();
   CalculateSense();
   Perception = (Vision + Hearing + Sense) / 3;
}
protected void CalculateMind()
{
   CalculateLearningRate();
   Mind = (MentalStrength + LearningRate + PathFinding) / 3;
}

//Sub-Stat Calculations
//Vitality
private void CalculateDefence()
{
   Defence = (PhysicalDefence + MentalDefence) / 2;
}

//Perception
private void CalculateVision()
{
   Vision = (PeripheralVision + MainVision) / 2;
}
private void CalculateSense()
{
   Sense = (PresenceSense + TargetSense) / 2;
}

//Mind
protected void CalculateLearningRate()
{
   LearningRate = (TaughtLearning + NaturalLearning) / 2;
}
*/
    }
}
