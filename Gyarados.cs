using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDungeonGame
{
    class Gyarados : Boss
    {
        public override int Special_Skill()
        {
            return 45;
        }

        public override int Strong_Attack()
        {
            return 35;
        }
    }
}
