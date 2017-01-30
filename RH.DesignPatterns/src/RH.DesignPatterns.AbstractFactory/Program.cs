using RH.DesignPatterns.AbstractFactory.Factory;

namespace RH.DesignPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PaisFactory brasil = new BrasilFactory();
            var pecas = new Pecas.Pecas(brasil);
            pecas.Compatibilidade();

            PaisFactory eua = new EUAFactory();
            pecas = new Pecas.Pecas(eua);
            pecas.Compatibilidade();
        }
    }
}
