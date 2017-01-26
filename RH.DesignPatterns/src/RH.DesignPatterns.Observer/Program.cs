using System;
using RH.DesignPatterns.Observer.Entities;
using RH.DesignPatterns.Observer.Servicos;

namespace RH.DesignPatterns.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var observadorServicos = new ObservadorServicos();
            var barMoe = new ObservadorBarMoe(observadorServicos);
            var barCanaBraba = new ObservadorBarCanaBraba(observadorServicos);
            var barArtesanal = new ObservadorBarArtesanal(observadorServicos);

            do
            {
                var randomPreco = new Random().Next(6,21);
                var randomBar = new Random().Next(1,4);
                Console.WriteLine("\n--------------------------------- ");
                Console.WriteLine("\nPreço: " + randomPreco);
                Console.WriteLine("Bar: " + randomBar + "\n");
                switch (randomBar)
                {
                    case 1:
                        barMoe.Atualizar(randomPreco); 
                        break;
                    case 2:
                        barCanaBraba.Atualizar(randomPreco);
                        break;
                    case 3: barArtesanal.Atualizar(randomPreco);
                        break;
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("\n");

            observadorServicos.DesaverbarObservador(barMoe);
            observadorServicos.DesaverbarObservador(barCanaBraba);
            observadorServicos.DesaverbarObservador(barArtesanal);

            Console.ReadKey();
        }
    }
}