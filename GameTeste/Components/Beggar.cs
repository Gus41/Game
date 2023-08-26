using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Components
{
    internal class Beggar
    {

        public int life = 100;
        public bool pinga = true;


        public void TrhowPinga()
        {
            this.pinga = false;
        }

    }
}
