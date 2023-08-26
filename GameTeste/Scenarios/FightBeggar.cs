using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class FightBeggar : Scene
    {
        private bool[] bag = State.getBag();

        public FightBeggar()
        {

            
                Add("----------Lutando com o Mendigo-------------");
                if (State.IsPoisoned())
                {
                    Add("Estado: Envenenado");
                }
                Add("MENDIGO: " + State.ShowbeggarLife());
                Add("------------------------------");
                Add("░░░░░░░▄█▄▄▄█▄");
                Add("▄▀░░░░▄▌─▄─▄─▐▄░░░░▀▄");
                Add("█▄▄█░░▀▌─▀─▀─▐▀░░█▄▄█");
                Add("░▐▌░░░░▀▀███▀▀░░░░▐▌");
                Add("████░▄█████████▄░████");
                Add("------------------------------");


                if (State.turno == 0)
                {
                    State.turno++;
                }
                else
                {
                    Add("ENVENENADO !! -5 de vida");
                    State.damage(5);
                }
                Add(State.showLife());


                Add("1 - Atacar");
                Add("2 - Defender");
                if (bag[1])
                {
                    // 1 - sanduiche , 2 - taco
                    Add("3 - Comer sanduiche");
                }
                if (bag[2])
                {
                    Add("4 -Atacar com o taco");
                }
            
            
            
        }

        public override Scene Options(string op)
        {

            

            if ( op == "1")
            {
                return new Attack();
            }
            if (op == "2")
            {
                return new Defend();

            }
            if (op == "3")
            {
                return new EatSandwich();
            }

            if (op == "4")
            {
                return new AttackGolf();
            }
           



            return new FightBeggar();
        }
    }
}
