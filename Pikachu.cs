using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDungeonGame
{
    class Pikachu : Player,IMoving
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
            return 85;
        }

        public override int Strong_Attack()
        {
            return 42;
        }
    }
}
