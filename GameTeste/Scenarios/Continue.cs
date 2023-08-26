using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class Continue : Scene
    {

        public Continue()
        {
            Add("-------------------");
            Add("   Continua...");
            Add("-------------------");
            Add("Obrigado por jogar " + State.GetNamePlayer());
        }
        public override Scene Options(string op)
        {
            Environment.Exit(0);
            return this;
        }
    }
}
