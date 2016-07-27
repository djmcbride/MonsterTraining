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
        public int HP { get; set; }
        public int Str { get; set; }
        public int Vit { get; set; }
        public int Dex { get; set; }
        public int Agi { get; set; }
        public int Mind { get; set; }
        public int Per { get; set; }

        public virtual void ReceiveAttack(Attack attack)
        {

        }

        public virtual void TakeDamage(int damage)
        {
            HP -= damage;
        }

        public virtual void GetHP()
        {
            UIUpdate.ShowHP("{0} has {1} HP", this.Name, HP);
        }

        //public abstract void AttackTarget();

    }
}
