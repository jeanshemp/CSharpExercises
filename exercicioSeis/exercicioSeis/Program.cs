using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioSeis
{
    class Program
    {
        static void Main(string[] args)
        {//escreva um programa que receba dois numeros e imprima o maior deles
            int maiorNumero;
            int primeiroNumero;
            int segundoNumero;
            int numeroAtual;

            Console.Write("Informe o primeiro Numero : ");
            primeiroNumero = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo Numero : ");
            segundoNumero = int.Parse(Console.ReadLine());

            if (primeiroNumero > segundoNumero)
            {
                Console.Write("O Primeiro numero é maior que o Segundo.");
               
            }

            else if (segundoNumero > primeiroNumero)
            {
                Console.Write("O Segundo numero é maior que  o Primeiro.");
            }
            Console.ReadKey();
        }
    }
}
