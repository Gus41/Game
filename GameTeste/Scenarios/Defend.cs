using GameTeste.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Scenarios
{
    internal class Defend: Scene
    {
        public Defend()
        {
            if (State.getBag()[2])
            {
                Add("Você usou o taco para se defender, o mendigo falhou em te atacar");

                Add("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                Add("░░░░░░░░░░▀█▄▀▄▀██████░▀█▄▀▄▀████▀");
                Add("░░░░░░░░░░░░▀█▄█▄███▀░░░▀██▄█▄█▀");
            }
            else
            {
                Add("O mendigo te atacou causando 10 de dano");
                Add("Ele está fraco pois não come a tres dias");

                Add("░░░░░░░▄█▄▄▄█▄");
                Add("▄▀░░░░▄▌─▄─▄─▐▄░░░░▀▄");
                Add("█▄▄█░░▀▌─▀─▀─▐▀░░█▄▄█");
                Add("░▐▌░░░░▀▀███▀▀░░░░▐▌");
                Add("████░▄█████████▄░████");
                Add("------------------------------");
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
