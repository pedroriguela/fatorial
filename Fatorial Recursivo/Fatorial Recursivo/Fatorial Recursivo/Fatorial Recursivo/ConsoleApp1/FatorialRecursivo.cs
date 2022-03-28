using System;

namespace FatorialRecursivo
{

	class MainClass
	{

		public static Int32 fatorial(Int32 num)
		{
			if (num == 1)
			{
				return 1;
			}
				return num * fatorial(num - 1);
		}

		public static void Main(string[] args)
		{
			Int32 num;
			String entrada;

			Console.Write("Digite um número inteiro: ");
			entrada = Console.ReadLine();
			num = Convert.ToInt32(entrada);

			Console.WriteLine("Fatorial de " + num + " é: " + fatorial(num));

		}
	}
}