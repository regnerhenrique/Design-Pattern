using RH.DesignPatterns.AbstractFactory.Pecas.PlacaMae;
using RH.DesignPatterns.AbstractFactory.Pecas.Processador;

namespace RH.DesignPatterns.AbstractFactory.Factory
{
    internal class BrasilFactory : PaisFactory
    {
        public override PlacaMae ObterPlacaMae()
        {
            return new PlacaMaeRogMaximusVIIIHeroAlpha();
        }

        public override Processador ObterProcessador()
        {
            return new Processadori76700();
        }
    }
}