using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Components
{
    internal class Player
    {
        public string name;
        public int life = 100;
        public bool[] bag = new bool[3];
        public bool poison = false;

        public Player()
        {
            this.bag[0] = false; 
            this.bag[1] = false;
            this.bag[2] = false;
            // 1 - sanduiche , 2 - taco
        }


        public void Damage(int n)
        {
            this.life -= n;
        }
        
        public void Poisoned()
        {
            this.poison = true;
        }
    }
}
