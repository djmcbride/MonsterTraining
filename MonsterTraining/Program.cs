using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster Rai = new Monster("Raichu");
            Rai.GetHP();
            Rai.TakeDamage(10);
            Rai.GetHP();
        }
    }
}
