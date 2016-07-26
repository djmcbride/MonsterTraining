using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTraining
{
    class Monster : Character
    {
        public Monster(string name = "No Name")
        {
            Name = name;
            HP = 100;
            Str = 10;
            Vit = 10;
            Dex = 10;
            Agi = 10;
            Mind = 10;
            Per = 10;
        }
    }
}
