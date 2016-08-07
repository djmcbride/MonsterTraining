using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTraining.Tests
{
    class Player
    {
        public Player(string name)
        {
            Name = name;
            Characters = new Character[6];
        }
        public string Name;
        public Character[] Characters;
    }
}
