using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDungeonGame
{
    class Mews : Boss
    {
        public override int Special_Skill()
        {
            return 65;
        }

        public override int Strong_Attack()
        {
            return 50;
        }
    }
}
