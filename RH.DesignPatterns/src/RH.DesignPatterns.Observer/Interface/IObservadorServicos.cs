using RH.DesignPatterns.Observer.Entities;

namespace RH.DesignPatterns.Observer.Interface
{
    public interface IObservadorServicos
    {
        void RegistrarObservador(Observador observador);
        void DesaverbarObservador(Observador observador);
        void ApresentarValores();
    }
}