using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class House : Scene
    {
        public House()
        {
            Add("Você encontra uma casa afastada da cidade");
            Add("Não parece que alguem more aqui");
            Add("░░░░░░░░░░░░░░░░▄▓▄");
            Add("░░░░▄█▄░░░░░░░░▄▓▓▓▄");
            Add("░░▄█████▄░░░░░▄▓▓▓▓▓▄");
            Add("░▀██┼█┼██▀░░░▄▓▓▓▓▓▓▓▄");
            Add("▄▄███████▄▄▄▄▄▄▄▄█▄▄▄▄");
            Add("1) Entrar");
            
        
        }

        public override Scene Options(string op)
        {
            if(op == "1")
            {
               return new InsideHouse();
            }
            else if( op == "2")
            {
                string[] atividades = new string[]
                {
                    "Varrer",
                    "Limpar",
                    "Tirar´pó"
                };

                return new List(atividades);
            }
            else
            {
                return new InsideHouse();
            }

        }
    }
}
