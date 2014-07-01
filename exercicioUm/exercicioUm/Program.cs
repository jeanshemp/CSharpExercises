using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioUm
{
    class Program
    {
        static void Main(string[] args)
        { //1 - calcular a soma de dois numeros inteiros informados pelo usuario
            int numeroA;
            int numeroB;
            int soma;
            Console.WriteLine("Informe o primeiro numero : ");
            numeroA = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo numero : ");
            numeroB = int.Parse(Console.ReadLine());

            soma = (numeroA + numeroB);

            Console.WriteLine("A soma de A+B = " + soma);
            Console.ReadKey();
        }
    }
}
