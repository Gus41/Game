using GameTeste.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste
{
    internal class State
    {
        // Só vai existir um
        private static Player player;
        private static Beggar mendigo = new Beggar();
        public static int turno = 0;
        //static funciona sem ter que Instanciar um objeto
        public static Player GetPlayer()
        {
           
            player = new Player();

            return player;
        }
        public static string GetNamePlayer() 
        {

            return player.name;
        }
        public static void SetItem(int chave)
        {
            player.bag[chave] = true;
        }
        
        public static void Poisoned()
        {
            player.Poisoned();
        }
        public static bool IsPoisoned()
        {
            return player.poison;
        }
        public static bool[] getBag()
        {
            return player.bag;
        }
        public static int GetLife()
        {
            return player.life;
        }
        public static string showLife()
        {
            string life = "Vida : ";

            string concat = "════";

            for(int i = 0; i < player.life; i +=10)
            {
                concat += " █ ";
            }
            concat += "════";

            life += concat;
            return new string(life);
        }
        public static void damage(int n)
        {
            player.Damage(n);
        }
        public static void BeggarDemage(int d)
        {
            mendigo.life -= d;
        }
        public static string ShowbeggarLife()
        {
            string life = "Vida : ";

            string concat = "════";

            for (int i = 0; i < mendigo.life; i += 10)
            {
                concat += " * ";
            }
            concat += "════";

            life += concat;
            return new string(life);
        }
        public static int getBeggarLife()
        {
            return mendigo.life;
        }
        public static bool HasPinga()
        {
            return mendigo.pinga;
        }
        public static void ThrowPinga()
        {
            mendigo.TrhowPinga();
        }
    }
}
