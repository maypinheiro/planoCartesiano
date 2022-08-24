using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PlanoCartesiano
{
    public class Tela
    {
        public void Imprimir(string[] quadrantes)
        {
            foreach (string quadrante in quadrantes)
            {
                if (quadrante != string.Empty)
                    Console.WriteLine(quadrante);
            }
        }

        public int[] NovoValor()
        {
            Console.Write("Diguite o eixo X e Y do Plano Cartesiano: ");
            string[] cordenada = Console.ReadLine().Split(' ');
            return new int[] {
                int.Parse(cordenada[0], CultureInfo.InvariantCulture),
                int.Parse(cordenada[1], CultureInfo.InvariantCulture)
            };
        }
    }

}
