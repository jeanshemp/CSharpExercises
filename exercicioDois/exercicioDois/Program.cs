using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioDois
{
    class Program
    {
        static void Main(string[] args)
        {//calcular  a divisão entre dois numeros reais infomados pelo usuario.
            int numeroA;
            int numeroB;
            int div;

            Console.WriteLine("primeiro numero = ");
            numeroA = int.Parse(Console.ReadLine());
            Console.WriteLine("segundo numero = ");
            numeroB = int.Parse(Console.ReadLine());

            if (numeroB == 0)
            {
                Console.WriteLine("Não existe divisão por 0");

            }
            div = (numeroA / numeroB);

          
            Console.WriteLine("A Divisão de A / B = " + div);
            Console.ReadKey();
            
        }
    }
}
