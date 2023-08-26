using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class City : Scene
    {
       public City()
        {
            
            Add("A cidadee é fria e barulhenta");
            Add("Você sente frio...");
            Add("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
            Add("▒▒▄▄▄▒▒▒█▒▒▒▒▄▒▒▒▒▒▒▒▒");
            Add("▒█▀█▀█▒█▀█▒▒█▀█▒▄███▄▒");
            Add("░█▀█▀█░█▀██░█▀█░█▄█▄█░");
            Add("░█▀█▀█░█▀████▀█░█▄█▄█░");
            Add(" ████████▀█████████████");
            Add("1) Entrar em uma casa e procurar abrigo");
           


        }

        public override Scene Options(string op)
        {
            if (op == "1")
            {
                return new House();
            }
            else if( op == "2")
            {
                return new Store();
            }

            return new Menu();
        }

    }
}
