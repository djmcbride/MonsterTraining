using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTraining
{
    public class Monster : Character
    {
        Trainer AssignedTrainer;
        public Monster(string name, string description, int[] affinities, int[] trainingPoints) : base(name, description, affinities, trainingPoints)
        {
        }

        public Monster(string name, string description, int[] affinities, int[] trainingPoints, Trainer trainer) : base(name, description, affinities, trainingPoints)
        {
            AssignedTrainer = trainer;
        }

        //Sub-routines
        public void AssignTrainer(Trainer trainer)
        {
            AssignedTrainer = trainer;
        }
    }
}
