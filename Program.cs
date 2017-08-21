using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDeTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1, lado2, lado3;
            Console.Write("Digite o lado 1: ");
            lado1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o lado 2: ");
            lado2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o lado 3: ");
            lado3 = Convert.ToInt32(Console.ReadLine());
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.Write("Equilátero");
            }
            else if(lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
            {
                Console.Write("Isósceles");
            }
            else
            {
                Console.Write("Escaleno");
            }
            Console.ReadLine();
        }
    }
}
