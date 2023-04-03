using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDungeonGame
{
    class Firy : Player,IMoving
    {
        public override int Defense_Skill()
        {
            return 7;
        }

        public void Moving()
        {
            this.hp = hp;
        }

        public override int Special_Skill()
        {
            return 84;
        }

        public override int Strong_Attack()
        {
            return 44;
        }
    }
}
