using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class InsideHouse : Scene
    {
        public InsideHouse()
        {
            Add("Ao entrar na casa você se depara com um mendigo dormindo.");
            Add(" O────────────────O");
            Add(" █▓██▄────────────█");
            Add(" █▓▓░▀▄▀░░░░░░░░░░█");
            Add(" █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Add(" █────────────────█");
            Add("1) Fugir e deixar o mendigo em paz");
            Add("2) Explorar a casa em silencio");
        }



        public override Scene Options(string op)
        {
            if( op == "1")
            {
                return new EscapeInsideHouse();
                // EscapeInsideHouse
            }else
            {
                //ExploreInsideHouse
                return new ExploreInsideHouse();

            }
        }
    }
}
