﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    public class Campo
    {
        // propriedades/atributos
        private int coluna;
        private int linha;
        private int altura;
        private int largura;

        //
        // métodos/operações
        //

        // método construtor 
        public Campo(int col, int lin, int alt, int lar)
        {
            this .coluna = col;
            this .linha = lin;
            this .altura = alt;
            this .largura = lar; 
        }
        public void desenhar()
        {
            int colunaFinal = this.coluna + this.largura;
            int linhaFinal = this.linha + this.altura;

            for (int x = this.coluna; x <= this.coluna + this.largura; x++)
            {
                // traça a linha horizontar superior
                Console.SetCursorPosition(x, this.linha);
                Console.Write('-');

                // traça a linha horizontal inferior
                Console.SetCursorPosition(x, linhaFinal);
                Console.Write('-');
            }

            for (int y = this.linha; y <= linhaFinal; y++)
            {
                // traça a linha verticar esquerda 
                Console.SetCursorPosition(this.coluna, y);
                Console.Write("|");

                // traça a linha vertical direita 
                Console.SetCursorPosition(colunaFinal, y);
                Console.Write("|");
            }
        }
    }
}
