using RH.DesignPatterns.AbstractFactory.Factory;
using RH.DesignPatterns.AbstractFactory.Interface;

namespace RH.DesignPatterns.AbstractFactory.Pecas
{
    internal class Pecas : IPecas
    {
        private readonly PlacaMae.PlacaMae _placaMae;
        private readonly Processador.Processador _processador;

        public Pecas(PaisFactory paisFactory)
        {
            _placaMae = paisFactory.ObterPlacaMae();
            _processador = paisFactory.ObterProcessador();
        }
        public void Compatibilidade()
        {
            _placaMae.Compatibilidade(_processador);
        }
    }
}