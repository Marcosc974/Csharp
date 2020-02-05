using System;

namespace OlaMundo01
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int ano, nasc, idade;

            Console.WriteLine("Qual seu nome?: ");
            nome = Console.ReadLine();

            Console.WriteLine("Olá: " + nome + ", em que ano você nasceu? : ");
            nasc = int.Parse(Console.ReadLine());
            Console.WriteLine("Em que ano estamos?: ");
            ano = int.Parse(Console.ReadLine());

            idade = ano - nasc;

            if (idade >= 18)
            {
                Console.WriteLine(nome + ", você têm: " + idade + " anos de idade, e é maior de Idade!");
            }
            else if (idade > 60)
            {
                Console.WriteLine(nome + ", você têm: " + idade + " anos de idade, e está na melhor Idade!");
            }
            else
            {
                Console.WriteLine(nome + ", você têm: " + idade + " anos de idade, e é Menor de Idade!");
            }
            Console.ReadKey();
        }
    }
}
