﻿using RH.DesignPatterns.Observer.Interface;

namespace RH.DesignPatterns.Observer.Entities
{
    public class ObservadorBarMoe : Observador, IObservador
    {
        private readonly IObservadorServicos _observadorServicos1;
        public ObservadorBarMoe(IObservadorServicos observadorServicos1)
        {
            _observadorServicos1 = observadorServicos1;
            Nome = "Bar do Moe";
            _observadorServicos1.RegistrarObservador(this);
        }

        public void Atualizar(float preco)
        {
            PrecoChopp = preco;
            _observadorServicos1.ApresentarValores();
        }
    }
}