﻿using System;

namespace RH.DesignPatterns.AbstractFactory.Pecas.PlacaMae
{
    internal class PlacaMaeRampageIVBlackEdition : PlacaMae
    {
        public override void Compatibilidade(Processador.Processador processador)
        {
            Console.WriteLine(GetType().Name + " compativel com o processador " + processador.GetType().Name);
            Console.ReadKey();
        }
    }
}