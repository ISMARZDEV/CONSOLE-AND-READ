//4. Capture dos números y muestre por pantalla la sumatoria dichos números.

using System;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado;

            Console.WriteLine("Digite su 1er numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite su 2do numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            resultado = num1 + num2;

            Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
        }
    }
}
