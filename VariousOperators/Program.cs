using System;
using System.Text;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            string num_int;
            byte n;

            Console.Write("Insere um número inteiro-não negativo: ");
            num_int = Console.ReadLine();

            n = byte.Parse(num_int);

            Console.WriteLine($"{n/2}");
        }
    }
}
