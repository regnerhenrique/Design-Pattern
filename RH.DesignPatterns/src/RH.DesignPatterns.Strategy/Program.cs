using System;
using RH.DesignPatterns.Entities;

namespace RH.DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa guri = new Jovem("Bruno", 23);
            Pessoa vovo = new Idoso("Roberto", 60);
            Console.WriteLine("O Sr. " + guri.Name + (guri.PegarPreferencial() == true ? "" : " não") + " pode ser atendido com uma senha preferencial!");
            Console.WriteLine("O Sr. " + vovo.Name + (vovo.PegarPreferencial() == true ? "" : " não") + " pode ser atendido com uma senha preferencial!");
            Console.ReadKey();
        }
    }
}