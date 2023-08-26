using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class Store : Scene
    {
        public Store()
        {
            Add("Bem vindo a loja do bob");
            Add("───────▄██████▄───────");
            Add("──────▐▀▀▀▀▀▀▀▀▌──────");
            Add("──────▌▌▀▀▌▐▀▀▐▐──────");
            Add("──────▐──▄▄▄▄──▌──────");
            Add("───────▌▐▌──▐▌▐───────");

            Add("Bob: Bem vindo, como posso ajudar? ");
            Add("1) Listar itens");
            Add("2) Voltar para a cidade");
        }

        public override Scene Options(string op)
        {
            if( op == "1")
            {
                // lista de Strings
                string[] i = new string[] 
                { 
                    "Roupas",
                    "Comida",
                    "Revolver",
                    "WalkieTalk",
                    "Poções"
                };


                return new List(i);
            }
            else
            {
                return new City();
            }
        }

      
    }
}
