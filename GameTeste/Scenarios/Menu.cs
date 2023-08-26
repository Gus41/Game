using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class Menu : Scene //extendendo outra classe
    {
        public Menu()
        {
            Add("1 - JOGAR ");
            Add("2 - SAIR ");

        }
        public override Scene Options(string op)
        {
            if(op != "1")
            {
                Environment.Exit(0);

            }
         
            return new CreateUser();

        }
    }
}
