using System;
using RH.DesignPatterns.Factory.Factory;

namespace RH.DesignPatterns.Factory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                var idadeDigitada = "";
                var nome = "";
                int msgErro;
                Console.WriteLine("Qual e o seu nome?");
                while (nome == "")
                {
                    nome = Console.ReadLine();
                }
                Console.WriteLine("\nQual e a sua idade?");
                while (idadeDigitada == "")
                {
                    idadeDigitada = Console.ReadLine();
                }
                while (!int.TryParse(idadeDigitada, out msgErro) || idadeDigitada == null)
                {
                    Console.WriteLine("\nIdade invalida, digite uma idade valida:");
                    idadeDigitada = Console.ReadLine();
                }
                var idade = int.Parse(idadeDigitada);
                var pessoaFactory = new FactoryPessoa(nome, idade);
                var tipoPessoa = pessoaFactory.CriarPessoa();
                Console.WriteLine("\nSr. " + tipoPessoa.GetNome() + ", " + tipoPessoa.MensagemTipoPessoa());
                Console.WriteLine("\n---------------------------------------\n");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}