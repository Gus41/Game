using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Base
{
    internal class Camera
    {

        public void Draw(World w)
        {
            int i, j;
            for (i = 0; i < w.Lines; i++)
            {
                for (j = 0; j < w.Columns; j++)
                {
                    Console.Write(w.Map[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}
