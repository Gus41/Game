using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class HappyEnding : Scene
    {

        public HappyEnding()
        {
            Add("Ao flertar com o mendigo você percebe que ele é o amor da sua vida");
            Add("Vocês se casam e vivem suas vidas na casa abandonada");

            Add("─▄██▄██▄");
            Add("─▀█████▀");
            Add("───▀█▀");
            Add("﹎ ﹎┈ ● o.﹎ ﹎");
            Add("┈ ┈  /█ /▓ ﹎ ┈");
            Add(" ▅▆▇█████▇▆▅");




            Add("HAPPY ENDING");
        }

        public override Scene Options(string op)
        {

            Environment.Exit(0);
            return new Menu();
        }
    }
}
