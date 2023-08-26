using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class BeggarTurn: Scene
    {
        public BeggarTurn()
        {


            if( State.HasPinga())
            {
                Add("O mendigo revida quebrando a garrafa de pinga na sua cabeça");
                Add("(Menos 30 de vida)");
                Add("------------------------------");
                Add("░░░░░░░▄█▄▄▄█▄");
                Add("▄▀░░░░▄▌─▄─▄─▐▄░░░░▀▄");
                Add("█▄▄█░░▀▌─▀─▀─▐▀░░█▄▄█");
                Add("░▐▌░░░░▀▀███▀▀░░░░▐▌");
                Add("████░▄█████████▄░████");
                Add("------------------------------");
                State.ThrowPinga();
                State.damage(30);
            }
            else
            {
                Add("O mendigo cospe no seu olho e te da um soco no estomago");
                Add("Menos 10 de vida");
                Add("------------------------------");
                Add("░░░░░░░▄█▄▄▄█▄");
                Add("▄▀░░░░▄▌─▄─▄─▐▄░░░░▀▄");
                Add("█▄▄█░░▀▌─▀─▀─▐▀░░█▄▄█");
                Add("░▐▌░░░░▀▀███▀▀░░░░▐▌");
                Add("████░▄█████████▄░████");
                Add("------------------------------");
                State.damage(10);
            }


            Add("Pressione enter para continuar");



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
