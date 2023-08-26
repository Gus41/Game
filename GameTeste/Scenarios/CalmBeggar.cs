using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class CalmBeggar : Scene
    {
        public CalmBeggar() 
        {
            Add("Você tenta acalmar ele, mas ele não fala sua lingua");
            Add("ele quebra a garrafa de whiski e te ataca ( - 20 de vida )");

            Add("▒▒▒░░░░░░░░░░▄▐░░░░");
            Add("▒░░░░░░▄▄▄░░▄██▄░░░");
            Add("░░░░░░▐▀█▀▌░░░░▀█▄░");
            Add("░░░░░░▐█▄█▌░░░░░░▀█▄");
            Add("░░░░░░░▀▄▀░░░▄▄▄▄▄▀▀");
            Add("░░░░░▄▄▄██▀▀▀▀░░░░░");
            Add("░░░░█▀▄▄▄█░▀▀░░░░░░");
            Add("░░░░▌░▄▄▄▐▌▀▀▀░░░░░");
            Add("░▄░▐░░░▄▄░█░▀▀░░░░░");
            Add("░▀█▌░░░▄░▀█▀░▀░░░░░");
            Add("░░░░░░░░▄▄▐▌▄▄░░░░░");
            Add("░░░░░░░░▀███▀█░▄░░░");
            Add("░░░░░░░▐▌▀▄▀▄▀▐▄░░░");
            Add("░░░░░░░▐▀░░░░░░▐▌░░");
            Add("░░░░░░░█░░░░░░░░█░░");

            // tirar 20 de vida
            State.damage(20);
            Add("1 - Começar batalha");
            Add("2 - Flertar com o mendigo");
        }

        public override Scene Options(string op)
        {
            if(op == "2")
            {
                return new HappyEnding();
            }
            return new FightBeggar();
        }

    }
}
