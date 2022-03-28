using System;

namespace Fatorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number, fatorial = 1;
            Console.WriteLine("Digite um número");
            number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
                Console.WriteLine("Não existe fatorial para números negativos");
            else if (number <= 1)
                Console.WriteLine("A fatorial de {0} é sempre {1}", number, fatorial);
            else
            {
                for (int counter = number; counter >= 2; counter--)
                {
                    fatorial = fatorial * counter;
                }
                Console.WriteLine("A fatorial de {0}! é {1}", number, fatorial);
            }
        }

    }
} 