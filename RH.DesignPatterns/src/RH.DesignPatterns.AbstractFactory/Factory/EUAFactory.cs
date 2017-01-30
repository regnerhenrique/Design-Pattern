using RH.DesignPatterns.AbstractFactory.Pecas.PlacaMae;
using RH.DesignPatterns.AbstractFactory.Pecas.Processador;

namespace RH.DesignPatterns.AbstractFactory.Factory
{
    internal class EUAFactory : PaisFactory
    {
        public override PlacaMae ObterPlacaMae()
        {
            return new PlacaMaeRampageIVBlackEdition();
        }

        public override Processador ObterProcessador()
        {
            return new ProcessadorI74820K();
        }
    }
}