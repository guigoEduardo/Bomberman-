using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    class Program
    {
        static void Main(string[] args)
        {
            // instaciando um novo objeto da classe Campo
            // classe objeto = new construtor (param1, param2...)
            Campo campinho = new Campo(1, 1, 20, 70);
            campinho.desenhar();

            Jogador jog1 = new Jogador(3, 3, "#",
                ConsoleKey.W, ConsoleKey.S,
                ConsoleKey.A, ConsoleKey.D);
            jog1.desenhar();

            Jogador jog2 = new Jogador(60, 15, "%",
                ConsoleKey.UpArrow, ConsoleKey.DownArrow,
                ConsoleKey.LeftArrow, ConsoleKey.RightArrow);
            jog2.desenhar();


            ConsoleKeyInfo tecla;
            while (true)
            {
                tecla = Console.ReadKey(true);
                if (tecla.Key == ConsoleKey.Escape) break;

                jog1.mover(tecla.Key);
                jog2.mover(tecla.Key);
            }


            Console.ReadKey();
        }
    }
}
