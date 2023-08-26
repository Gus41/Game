using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class StoreItens: Scene
    {
        public StoreItens()
        {
            Add("--------Saldo : 0------");
            Add("Bob: Esses são is itens que posso te vender hoje: ");
            Add("Revolver: 50$");
            Add("░▄▌░░░░░░░░░▄");
            Add("████████████▄");
            Add("░░░░░░░░▀▐████");
            Add("░░░░░░░░░░░▐██▌");

            Add("");
            Add("Walkie Talkie: 20$");
            Add(" ────▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Add("▀▀▀█─▄▄▄▄▄▄─▄─▄─▄─█");
            Add("───█─█────█─▄▀▄▀▄─█");
            Add("───█─█▄▄▄▄█─▄▀▄▀▄─█");
            Add("───▀▄▄▄▄▄▄▄▄▄▄▄▄▄▄▀");

            Add("1) Revolver");
            Add("2) Walkie Talkie");
            Add("3) Sair");

        }
        public override Scene Options(string op)
        {
            if (op == "!")
            {
                return new Store();
            }
            else if (op == "2")
            {
                return new Store();
            }
            else
            {
                return new Store();
            }
        }
    }
}
