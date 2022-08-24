using System;
using System.Globalization;

namespace PlanoCartesiano

{
    internal class Program
    {
        static void Main(string[] args)
        {

            Tela tela = new Tela();
            Validacao valida = new Validacao();

            var numeros = tela.NovoValor();

            var valida1 = new Quadrante1();
            var valida2 = new Quadrante2();
            var valida3 = new Quadrante3();
            var valida4 = new Quadrante4();

            while (!valida.EZero(numeros))
            {
                tela.Imprimir(new string[] { 
                    valida1.ValidaQuadrante(numeros[0], numeros[1]),
                    valida2.ValidaQuadrante(numeros[0], numeros[1]),
                    valida3.ValidaQuadrante(numeros[0], numeros[1]),
                    valida4.ValidaQuadrante(numeros[0], numeros[1])
                });

                numeros = tela.NovoValor();
            }

        }
    }
}