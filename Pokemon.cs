using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDungeonGame
{
    class Pokemon
    {
        private int Hp;
        private int Mp;
        private string Name;
        private int Defense;
        public int hp
        {
            get { return Hp; }
            set { Hp = value; }
        }

        public int mp
        {
            get { return Mp; }
            set { Mp = value; }
        }

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        

        public int defense
        {
            get { return Defense; }
            set { Defense = value; }
        }


        public int Common_Attack()
        {
            return 20;
        }

        public void Hit(int att)
        {
            this.hp -= att;
        }



    }
}
