using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioTres
{
    class Program
    {
        static void Main(string[] args)
        {//Verificar se um numero digitado é impar ou par
            int numero;
            
            Console.WriteLine("Digite o numero  a ser verificado : ");
            numero = int.Parse(Console.ReadLine());

            if (numero / 2 * 2 == numero)
            {
               
                Console.WriteLine("O numero "+numero+" é par.");
            }
            else if (numero / 2 != numero)
            {
              
                Console.WriteLine("O numero " + numero + " é impar.");
            }

            Console.ReadKey();

        }
    }
}
