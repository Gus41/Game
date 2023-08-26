using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class Died: Scene
    {

        public Died()
        {
            Add("O mendigo te acerta umma bituca de cigarro no olho");
            Add("Você fica cego e cai pela janela, quebrando o pescoço");


            Add("░░░░░▄▄▄▄▀▀▀▀▀▀▀▀▄▄▄▄▄▄░░░░░░░");
            Add("░░░░░█░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░▀▀▄░░░░");
            Add("░░░░█░░░▒▒▒▒▒▒░░░░░░░░▒▒▒░░█░░░");
            Add("░░░█░░░░░░▄██▀▄▄░░░░░▄▄▄░░░░█░░");
            Add("░▄▀▒▄▄▄▒░█▀▀▀▀▄▄█░░░██▄▄█░░░░█░");
           Add(" █░▒█▒▄░▀▄▄▄▀░░░░░░░░█░░░▒▒▒▒▒░█");
           Add(" █░▒█░█▀▄▄░░░░░█▀░░░░▀▄░░▄▀▀▀▄▒█");
           Add(" ░█░▀▄░█▄░█▀▄▄░▀░▀▀░▄▄▀░░░░█░░█░");
           Add(" ░░█░░░▀▄▀█▄▄░█▀▀▀▄▄▄▄▀▀█▀██░█░░");
           Add(" ░░░█░░░░██░░▀█▄▄▄█▄▄█▄████░█░░░");
           Add(" ░░░░█░░░░▀▀▄░█░░░█░█▀██████░█░░");
           Add(" ░░░░░▀▄░░░░░▀▀▄▄▄█▄█▄█▄█▄▀░░█░░");
           Add(" ░░░░░░░▀▄▄░▒▒▒▒░░░░░░░░░░▒░░░█░");
            Add("░░░░░░░░░░▀▀▄▄░▒▒▒▒▒▒▒▒▒▒░░░░█░");
            Add("░░░░░░░░░░░░░░▀▄▄▄▄▄░░░░░░░░█░░");
            Add("---------------------------------");
            Add("1 - Reiniciar");
        }

        public override Scene Options(string op)
        {
            return new Menu();
        }
    }
}
