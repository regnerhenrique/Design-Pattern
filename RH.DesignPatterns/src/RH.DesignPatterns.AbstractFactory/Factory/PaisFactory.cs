using RH.DesignPatterns.AbstractFactory.Pecas.PlacaMae;
using RH.DesignPatterns.AbstractFactory.Pecas.Processador;

namespace RH.DesignPatterns.AbstractFactory.Factory
{
    internal abstract class PaisFactory
    {
        public abstract PlacaMae ObterPlacaMae();
        public abstract Processador ObterProcessador();
    }
}