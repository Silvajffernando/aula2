using System;

namespace ExercicioCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exercício condicionais");
            Console.WriteLine("Digite sua idade");
            var numero = Console.ReadLine();
            var idade = Convert.ToInt32(numero);


            if (idade >= 13 && idade < 19)
            {
                Console.WriteLine("Adolescente");

            }
            else if (idade > 19 && idade < 60)
            {
                Console.WriteLine("Adulto");

            }
            else if (idade > 60)
            {
                Console.Write("Idoso");

            }
            else

            {
                Console.WriteLine("Criança");
            }
            Console.ReadKey();
        }

    }
}
