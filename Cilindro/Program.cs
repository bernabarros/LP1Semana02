using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string a;
            string r;
            double num_altura;
            double num_raio;
            double V;
            double Sa;

            Console.Write("Insere a altura do cilindro: ");
            a = Console.ReadLine();
            num_altura = double.Parse(a);

            Console.Write("Insere o raio do cilindro: ");
            r = Console.ReadLine();
            num_raio = double.Parse(r);

            V = Math.PI*Math.Pow(num_raio,2)*num_altura;
            Console.WriteLine($"{V:f3}");

            Sa = 2*Math.PI*num_raio*(num_raio + num_altura);
            Console.WriteLine($"{Sa:f3}");

        }
    }
}
