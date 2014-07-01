using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioQuatro
{
    class Program
    {
        static void Main(string[] args)
        {//calcular a area de um reatangulo (Area  = base x altura)
            float areaRetangulo;
            float baseRetangulo;
            float alturaRetangulo;
            

            Console.Write("Entre com  a medida da Base = ");
            baseRetangulo = float.Parse(Console.ReadLine());
            Console.Write("Entre com  a medida da Altura = ");
            alturaRetangulo = float.Parse(Console.ReadLine());

            areaRetangulo = (baseRetangulo * alturaRetangulo);

            Console.WriteLine("O total da Área é = " + areaRetangulo);

            
            Console.ReadKey();

        }
    }
}
