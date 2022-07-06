using System;

namespace Engenhos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, soma = 0;

            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++) {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine("A soma dos números multiplos de 3 e 5 entre 0 e " + numero + " é: " + soma);
        }
    }
}
