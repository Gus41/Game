using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class List : Scene
    {
        public string[] Itens;

        public List(string[] i)
        {
            Itens = i;

            int cont = 1;
            Add("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            foreach (string s in Itens)
            {
                string line = $"█{cont++}->{s}";
                line = line.PadRight(21,' ');
                line += "█";
                Add(line);
                  
            }
            Add("█--------------------█");
            Add("█0-> Sair            █");
            Add("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");

        }

        public override Scene Options(string op)
        {

            throw new NotImplementedException();
        }
    }
}
