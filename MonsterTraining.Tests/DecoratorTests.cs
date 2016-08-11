using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MonsterTraining.Tests

{
    [TestClass]
    public class DecoratorTest
    {
        [TestMethod]
        public void DecorateAttack()
        {
            double[] stats = new double[StatList.ArrayLength];

            stats[StatList.MeleeStrength] = 10;
            stats[StatList.MentalStrength] = 15;

            Attack punch = new Attack("Punch", 10, stats);
            Console.WriteLine("{0} has dealt {1} damage!", punch.Name, punch.Damage);

            Fire firePunch = new Fire(punch, 20, "Fire");
            Console.WriteLine("{0} {1} has dealt {2} damage!", firePunch.ModifierText, firePunch.Name, firePunch.Damage);
        }

        //Component Interface
        public interface ITechnique
        {
            string Name
            {
                get; set;
            }
            double Damage
            {
                get; set;
            }

            double[] Stats
            {
                get; set;
            }
        }

        //Concrete Component
        public class Attack : ITechnique
        {
            public string Name
            {
                get; set;
            }
            public double Damage
            {
                get; set;
            }
            public double[] Stats
            {
                get; set;
            }

            public Attack(string name, double damage, double[] stats)
            {
                Name = name;
                Stats = stats;
                Damage = damage * Stats[StatList.MeleeStrength];
            }
        }

        //this would be my decorator shell 
        public abstract class AttackDecorator : ITechnique
        {
            private ITechnique _attack;

            public AttackDecorator(ITechnique attack) //Decorator function takes an altered component
            {
                _attack = attack; //New component then overwrites the original
            }
            public string Name
            {
                get { return _attack.Name; }
                set { }
            }
            public double Damage
            {
                get { return _attack.Damage; }
                set { }
            }
            public double[] Stats
            {
                get { return _attack.Stats; }
                set { }
            }
        }


        //This would be my ConcreteDecorator (fire element etc.)
        public class Fire : AttackDecorator
        {
            public Fire(ITechnique attack, int extraDamage, string modifierText) : base(attack)
            {
                ExtraDamage = extraDamage;
                ModifierText = modifierText;
            }


            public int ExtraDamage
            {
                get; set;
            }

            public string ModifierText
            {
                get; set;
            }

            public new double Damage
            {
                get
                {
                    return base.Damage + (ExtraDamage * Stats[StatList.MentalStrength]);
                }
            }
        }

        public class Earth : AttackDecorator
        {
            public Earth(ITechnique attack, int extraDamage, string modifierText) : base(attack)
            {
                ExtraDamage = extraDamage;
                ModifierText = modifierText;
            }


            public int ExtraDamage
            {
                get; set;
            }

            public string ModifierText
            {
                get; set;
            }

            public new double Damage
            {
                get
                {
                    return base.Damage + (ExtraDamage * Stats[StatList.MentalStrength]);
                }
            }
        }

        public void buildAttacks()
        {

        }
    }
}