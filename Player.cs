using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDungeonGame
{
     abstract class Player:Pokemon
    {
       
        public void Eat_HpPotion()
        {
            hp += 20;
        }
        public void Eat_AttPotion()
        {
            mp += 20;        
        }
        public void Eat_DfPotion()
        {
            defense += 5;
        }

        public abstract int Strong_Attack();
        public abstract int Special_Skill();
        public abstract int Defense_Skill();

    }
}
