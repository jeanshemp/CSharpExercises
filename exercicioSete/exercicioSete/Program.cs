using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioSete
{
    class Program
    {
        static void Main(string[] args)
        { //Escreva um programa que peça um valor e mostre na tela se o valor é positivo ou negativo.
            int valorDigitado;

            Console.Write("Digite um valor:");
            valorDigitado = int.Parse(Console.ReadLine());

            if (valorDigitado >= 0){
                Console.Write ("Esse valor é positivo");
            }

            else if (valorDigitado < 0)
            {
                Console.Write("Esse valor é negativo!");
            }

            Console.ReadKey();
        }
    }
}
