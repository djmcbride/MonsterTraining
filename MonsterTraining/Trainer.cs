using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTraining
{
    public class Trainer : Character
    {
        public Trainer(string name, string description, int[] stats) : base(name, description, stats)
        {
            Monsters = new Character[6];
        }
        public Character[] Monsters;
    }
}
