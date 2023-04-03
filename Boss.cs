using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDungeonGame
{
    abstract class Boss:Pokemon
    {
        abstract public int Special_Skill();
        abstract public int Strong_Attack();
        public void Random_Heal(int a)
        {
            hp += a;
        }
    }
}
