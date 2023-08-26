using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class AttackGolf : Scene
    {




        public AttackGolf() 
        {
            Add("Você bate com o taco de golfe no mendigo causando 35 de dano");




            Add("1 - Continuar");
            State.BeggarDemage(35);
        }



        public override Scene Options(string op)
        {
            if( State.getBeggarLife() <= 0 )
            {
                return new Win();
            }
            else
            {
                return new BeggarTurn();
            }
        }
    }
}

