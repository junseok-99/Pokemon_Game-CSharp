using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDungeonGame
{
    class User
    {
        private int Money=500;
        private int Level=1;
        private string Nickname;
        private int Hp_Potion=3;
        private int Att_Potion=3;
        private int Df_Potion=3;
        public int money
        {
            get { return Money; }
            set { Money = value; }
        }
        public string nickname
        {
            get { return Nickname; }
            set { Nickname = value; }
        }
        public int hp_potion
        {
            get { return Hp_Potion; }
            set { Hp_Potion = value; }
        }
        public int att_potion
        {
            get { return Att_Potion; }
            set { Att_Potion = value; }
        }
        public int df_potion
        {
            get { return Df_Potion; }
            set { Df_Potion = value; }
        }
        public int level 
        {
            get { return Level; }
            set { Level = value; }
        }




    }
}
