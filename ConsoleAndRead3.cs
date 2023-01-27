3. Pregunte y capture su nombre y muestre por pantalla un saludo personalizado.

using System;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("¿Cuál es tu nombre?");
            name = Console.ReadLine();
            Console.WriteLine("Hola {0}", name);
        }   
    }
}
