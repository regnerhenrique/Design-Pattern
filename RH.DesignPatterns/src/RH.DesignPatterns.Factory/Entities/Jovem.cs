﻿namespace RH.DesignPatterns.Factory.Entities
{
    public class Jovem : Pessoa
    {
        public override string mensagemTipoPessoa()
        {
            return "encaminhando-o para o atendimento como atendimento normal. \n\nImprimindo senha... \n(Senha Atendimento Normal)";
        }
    }
}