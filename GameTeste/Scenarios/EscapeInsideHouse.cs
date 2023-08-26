using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class EscapeInsideHouse : Scene
    {
        public EscapeInsideHouse()
        {
            Add("Ao se virar para escapar, você acorda o mendigo, ele fica assustado.");
            Add("Esse mendigo te lembra um personagem de desenho animado");

           Add(" ░░░░░░░░░░░░░░░░▄▄█▀▀██▄▄░░░░░░░");
           Add(" ░░░░░░░░░░░░░▄█▀▀░░░░░░░▀█░░░░░░");
            Add("░░░░░░░░░░░▄▀░░░░░░░░░░░░░█░░░░░");
           Add(" ░░░░░░░░░▄█░░░░░░░░░░░░░░░█░░░░░");
           Add(" ░░░░░░░██▀░░░░░░░▄▄▄░░▄░█▄█▄░░░░");
            Add("░░░░░▄▀░░░░░░░░░░████░█▄██░▀▄░░░");
           Add(" ░░░░█▀░░░░░░░░▄▄██▀░░█████░██░░░");
           Add(" ░░░█▀░░░░░░░░░▀█░▀█▀█▀▀▄██▄█▀░░░");
           Add(" ░░░██░░░░░░░░░░█░░█░█░░▀▀▄█▀░░░░");
           Add(" ░░░░█░░░░░█░░░▀█░░░░▄░░░░░▄█░░░░");
           Add(" ░░░░▀█░░░░███▄░█░░░░░░▄▄▄▄█▀█▄░░");
           Add(" ░░░░░▀██░░█▄▀▀██░░░░░░░░▄▄█░░▀▄░");
           Add(" ░░░░░░▀▀█▄░▀▄▄░▄░░░░░░░███▀░░▄██");
           Add(" ░░░░░░░░░▀▀▀███▀█▄░░░░░█▀░▀░░░▀█");
           Add(" ░░░░░░░░░░░░▄▀░░░▀█▄░░░░░▄▄░░▄█▀");
           Add(" ░░░▄▄▄▀▀▀▀▀█▀░░░░░█▄▀▄▄▄▄▄▄█▀▀░░");
           Add(" ░▄█░░░▄██▀░░░░░░░░░█▄░░░░░░░░░░░");




            Add("1 - Tentar acalmar o mendigo");
        }

        public override Scene Options(string op)
        {
            return new CalmBeggar();
        }


    }
}
