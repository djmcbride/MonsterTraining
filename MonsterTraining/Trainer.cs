using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTraining
{
    public class Trainer : Character
    {
        public Trainer(string name, string description, double[] affinities, double[] elementalMastery, double[] stats) : base(name, description, affinities, elementalMastery, stats)
        {
            Monsters = new Monster[6];
        }
        public Monster [] Monsters;
    }
}
