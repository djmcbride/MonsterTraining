using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTraining
{
    public abstract class Character
    {
        public string Name { get; set; }
        //Todo: Figure out how to create an enum that you can get/set
        //enum Gender { Male, Female, None }
        protected int HP { get; set; }
        protected int Str { get; set; }
        protected int Vit { get; set; }
        protected int Dex { get; set; }
        protected int Agi { get; set; }
        protected int Mind { get; set; }
        protected int Per { get; set; }

        public virtual void TakeDamage(int damage)
        {
            HP -= damage;
        }

        public virtual void GetHP()
        {
            UIUpdate.Message(HP);
        }

        //public abstract void AttackTarget();

    }
}
