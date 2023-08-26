using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class EatSandwich : Scene
    {
        public EatSandwich() 
        {
            Add("Você come o sanduiche e agora está com dor de barriga");
            Add("Menos 10 de vida");

            Add("──▄────▄▄▄▄▄▄▄────▄───");
            Add("─▀▀▄─▄█████████▄─▄▀▀──");
            Add("─────██─▀███▀─██──────");
            Add("───▄─▀████▀████▀─▄────");
            Add("─▀█────██▀█▀██────█▀──");
            Add("Pressione enter para continuar");

            State.damage(10);


            
        }



        public override Scene Options(string op)
        {
            int life = State.GetLife();

            if (life <= 0)
            {
                return new Died();
            }

            return new FightBeggar();
        }
    }
}
