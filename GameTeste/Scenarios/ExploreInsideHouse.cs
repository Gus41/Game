using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class ExploreInsideHouse : Scene
    {

        public ExploreInsideHouse() 
        {
            Add("Ao explorar a casa você encontra um taco de golfe quebrado e um pão mofado");


            Add("░░░░░▀▀░░█░░░░░░▄░▄");
            Add("║░░░░██░████████████");
            Add("░░░░░░▄▄░░█░░░░░░▀░▀");
            


            Add("1 - Pegar o taco");
            Add("2 - Pegar o Pão");
            Add("3 - Pegar os dois");

        }
        public override Scene Options(string op)
        {
            if(op == "1")
            {
                // 1 - sanduiche , 2 - taco
                State.SetItem(2);
            }
            else if (op == "2")
            {
                State.SetItem(1);

            }
            else
            {
                State.SetItem(1); 
                State.SetItem(2);

            }

            return new ExploreFaield();
        }
    }
}
