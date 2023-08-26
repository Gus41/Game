using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTeste.Base
{
    internal class World
    {
        public int Lines;
        public int Columns;
        public char[,] Map;

        public World(int lines, int col)
        {
            Lines = lines;
            Columns = col;
            // usar o this apenas quando os atributos e parametros tiverem o mesmo nome
            Map = new char[Lines, Columns];

        }

        public void Fill()
        {
            int i, j;
            for (i = 0; i < Lines; i++)
            {
                for (j = 0; j < Columns; j++)
                {
                    // ╝ ╔ ╚ ╗ ═ ║
                    if (i == 0 && j == 0)
                    {
                        Map[i, j] = '╔';
                    }
                    else if (i == Lines - 1 && j == 0)
                    {
                        Map[i, j] = '╚';
                    }
                    else if (i == Lines - 1 && j == Columns - 1)
                    {
                        Map[i, j] = '╝';
                    }
                    else if (i == 0 && j == Columns - 1)
                    {
                        Map[i, j] = '╗';
                    }
                    else if (i == 0 || i == Lines - 1)
                    {
                        Map[i, j] = '═';
                    }
                    else if (j == 0 || j == Columns - 1)
                    {
                        Map[i, j] = '║';
                    }
                    else
                    {
                        Map[i, j] = ' ';
                    }
                }

            }
        }
        public void Add(int l, int c, String text)
        {
            string[] vet;

            vet = text.Split('\n');

            int pos = c;
            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = 0; j < vet[i].Length; j++)
                {
                    String palavra = vet[i];
                    palavra = palavra.Replace("\r", "");
                    Map[l, pos] = palavra[j];
                    pos++;
                }
                pos = c;
                l++;
            }

        }
        
    }
}
