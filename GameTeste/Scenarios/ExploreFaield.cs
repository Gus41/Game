using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class ExploreFaield : Scene
    {

        public ExploreFaield() 
        {
            Add("Ao se virar, você se depara com o mendigo em pé, ele grita assustado");
            Add("O mendigo joga uma garrafa de corote com mijo em você, agora você está com poison");

           Add(" █▄▀▄▀▄█");
           Add(" █░▀░▀░█▄");
           Add(" █░▀░░░█─█");
           Add(" █░░░▀░█▄▀");
           Add(" ▀▀▀▀▀▀▀");




            Add("1 - Lutar");
            State.Poisoned();
        }

        public override Scene Options(string op)
        {
            return new FightBeggar();
        }
    }
}
