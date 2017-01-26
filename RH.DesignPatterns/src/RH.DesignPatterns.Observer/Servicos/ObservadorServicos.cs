using System;
using System.Collections.Generic;
using RH.DesignPatterns.Observer.Entities;
using RH.DesignPatterns.Observer.Interface;

namespace RH.DesignPatterns.Observer.Servicos
{
    public class ObservadorServicos : IObservadorServicos
    {
        private readonly List<Observador> _listaObservador1;

        public ObservadorServicos()
        {
            _listaObservador1 = new List<Observador>();
        } 
        public void RegistrarObservador(Observador observador)
        {
            Console.WriteLine("Observador " + observador.GetNome() + " registrado na lista de observadores.");
            _listaObservador1.Add(observador);
        }

        public void DesaverbarObservador(Observador observador)
        {
            Console.WriteLine("Observador " + observador.GetNome() + " desaverbado da lista de observadores.");
            _listaObservador1.Remove(observador);
        }

        public void ApresentarValores()
        {
            foreach (var observador in _listaObservador1)
            {
                Console.WriteLine("Valor no " + observador.GetNome() + ": " + observador.GetPrecoChopp());
            }
        }
    }
}