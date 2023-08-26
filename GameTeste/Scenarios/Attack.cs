using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class Attack : Scene
    {
        
        public Attack() 
        {
            Add("Você acerta um soco no nariz do mendigo");
            Add("Causando 15 de dano nele");
            Add("░░░░░░▄▄▄▄▄▓▓▓▄▄▄░░░░░");
            Add("░░░░▄▄▓▓▓▓▓▓▓▓▓▓▓▓▓▄░░░");
            Add("░░▄▄▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▀█▄░");
            Add("░▓▓▌▓▓▓░░▒▒▒▒▀(◐)▒▒▒▒▒█▓");
            Add("░▓▓▌▓▓░▒▒▓(◐)▓░░░▒▓▓(◐)█▓");
            Add("▓▓▌▓▓█▄█▀▄▄░▀░▀▄▄▀░░█░█");
            Add("▓▓▌▓▓▀▄█▄█░█▀▄▄▄▄▄▀██░█");
            Add("░▓▓▌▓▓░█░███▄█▄█▄███░░█");
            Add("░▓▓▌▓▓░█░███████████░░█");
            Add("░▓▓▌▓▓░█░███████████░░█");
           Add(" ░▓▓▌▓▓░▀▀█░█▀█▀█▀███░█");
           Add(" ░░▓▓▌▓▓░░░▀▀▄█▄█▄█▄▀░█");
           Add(" ░░▓▓▌▓▓▓▓▀▀▄▄▄▄▄▄▄▄▄▄▀");

            Add("1 - Continuar");


            State.BeggarDemage(15);
        
        }

        public override Scene Options(string op)
        {
            return new BeggarTurn();
            //turno do mendigo

        }
    }
}
