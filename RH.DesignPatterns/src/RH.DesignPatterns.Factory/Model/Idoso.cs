namespace RH.DesignPatterns.Factory.Model
{
    public class Idoso : Pessoa
    {
        public Idoso(string nome, int idade)
        {
            SetNome(nome);
            SetIdade(idade);
        }

        public override string MensagemTipoPessoa()
        {
            return "encaminhando-o para o atendimento como atendimento preferencial. \n\nImprimindo senha... \n(Senha Atendimento Preferencial)";
        }
    }
}