using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class Win: Scene
    {
        public Win() 
        {
            Add("-----VITORIA-----");
            Add("O mendigo recua e se esconde casa a dentro, você resolve ir atrás dele e explorar a casa");
            Add("Enquanto isso");
            Add("█▓▒▓█▀██▀█▄░░▄█▀██▀█▓▒▓█");
           Add(" █▓▒░▀▄▄▄▄▄█░░█▄▄▄▄▄▀░▒▓█");
            Add("█▓▓▒░░░░░▒▓░░▓▒░░░░░▒▓▓█");

            Add("1 - Explorar a casa atraz do mendigo");
        }

        public override Scene Options(string op)
        {
            return new Continue();
        }
    }
}
