using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioCinco
{
    class Program
    {
        static void Main(string[] args)
        {//Dado pelo usuario tres notas, calcular a media de um aluno
            int notaUm;
            int notaDois;
            int notaTres;
            float mediaAluno;

            Console.Write("Digite  a primeira nota : ");
            notaUm = int.Parse(Console.ReadLine());
            Console.Write("Digite  a segunda nota : ");
            notaDois = int.Parse(Console.ReadLine());
            Console.Write("Digite  a terceira nota : ");
            notaTres = int.Parse(Console.ReadLine());

            mediaAluno = (notaUm + notaDois + notaTres) / 3;

            Console.WriteLine("A media é : " + mediaAluno);
            Console.ReadKey();
            
        }
    }
}
