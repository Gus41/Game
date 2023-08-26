using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Base
{
    internal abstract class Scene
    {
        public World w;
        public Camera cam;
        public int top = 1;
        public Scene()
        {
            w = new World(25, 100);
            w.Fill();

            cam = new Camera();
        }

        public void Add(string text)
        {
            w.Add(top++,1,text);
        }

        public string RequestUserOption()
        {
            Console.WriteLine("Digite sua resposta: ");
            String op = Console.ReadLine();

            Console.WriteLine($"O usuario escolheu : {op} ");

            return op;
        }

        public void Move(Scene s)
        {
            s.Show();
            String op = s.RequestUserOption();

            // Criando a scena que o usuario escolheu
            Scene sn = s.Options(op);
            s.Move(sn);
            
        }

        //todo mundo que utilizar scene sera obrigado a dar opções
        public abstract Scene Options(string op);

        public void Show()
        {
            Console.Clear();
            cam.Draw(w);
        }

    }
}
