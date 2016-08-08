using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTraining
{
    public class Monster : Character
    {
        public Monster(string name, string description, int[] stats) : base(name, description, stats)
        {
        }

        public Monster(string name, string description, int[] stats, Trainer trainer) : base(name, description, stats)
        {
            AssignedTrainer = trainer;
        }
        Trainer AssignedTrainer;

        //Sub-routines
        public void AssignTrainer(Trainer trainer)
        {
            AssignedTrainer = trainer;
        }
    }
}
