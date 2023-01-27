//6. Obtener el promedio de 2 numeros

using System;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double num1, num2, num3, resultado;

            Console.WriteLine("Digite su 1er numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite su 2do numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite su 3er numero: ");
            num3 = Convert.ToDouble(Console.ReadLine());


            resultado = num1 + num3 / num2;

            if (num2 != 0)
            {
                Console.WriteLine("{0} + {1} / {2} = {3:N2}", num1, num3, num2, resultado);
            }
            else
            {
                Console.WriteLine("No se puede dividir entre 0");
            }
        }
    }
}
