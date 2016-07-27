using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTraining
{
    public abstract class Technique
    {
        public string Name { get; set; }
        protected string Description { get; set; }
        public Character TechniqueSource { get; set; }
        public Character TechniqueTarget { get; set; }
        protected int damageCalc;
        
    }
}
