using RH.DesignPatterns.Factory.Entities;
using System;

namespace RH.DesignPatterns.Factory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                var idade = 0;
                var idadeDigitada = "";
                var nome = "";
                int msgErro;
                Pessoa tipoPessoa;
                Console.WriteLine("Qual e o seu nome?");
                while (nome == "")
                {
                    nome = Console.ReadLine();
                }
                Console.WriteLine("\nQual e a sua idade?");
                while (idadeDigitada == "")
                {
                    idadeDigitada = Console.ReadLine();
                };
                while (!int.TryParse(idadeDigitada, out msgErro))
                {
                    Console.WriteLine("\nIdade invalida, digite uma idade valida:");
                    idadeDigitada = Console.ReadLine();
                }
                idade = int.Parse(idadeDigitada);
                if (idade > 60)
                {
                    tipoPessoa = new Idoso();
                }
                else
                {
                    tipoPessoa = new Jovem();
                }
                Console.WriteLine("\nSr. " + nome + ", " + tipoPessoa.mensagemTipoPessoa());
                Console.WriteLine("\n---------------------------------------\n");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}