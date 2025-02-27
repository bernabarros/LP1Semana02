using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string numero_int;
            sbyte n;

            Console.Write("Insere um número inteiro: ");
            numero_int = Console.ReadLine();
            n = sbyte.Parse(numero_int);
            n = ++n;
            Console.WriteLine($"{n}");
            n = --n;
            Console.WriteLine($"{n}");

        }
    }
}
