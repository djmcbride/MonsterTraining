using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTraining
{
    public class Attack : Technique
    {
        int SenAtk = TechniqueSender.Str;
        public static Character TechniqueSender
        {
            get;
            private set;
        }
    }
}
