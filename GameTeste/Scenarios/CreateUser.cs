using GameTeste.Base;
using GameTeste.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class CreateUser: Scene
    {
        public CreateUser()
        {
            Add("=====Criação de jogador====");
            Add("Informe o nome de seu jogador: ");
            
        }
        public override Scene Options(string op)
        {
            Player p = State.GetPlayer() ;
            p.name = op;

            return new City();
        }
    }
}
