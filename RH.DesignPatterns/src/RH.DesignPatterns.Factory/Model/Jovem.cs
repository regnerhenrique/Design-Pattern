namespace RH.DesignPatterns.Factory.Model
{
    public class Jovem : Pessoa
    {
        public Jovem(string nome, int idade)
        {
            SetNome(nome);
            SetIdade(idade);
        }

        public override string MensagemTipoPessoa()
        {
            return "encaminhando-o para o atendimento como atendimento normal. \n\nImprimindo senha... \n(Senha Atendimento Normal)";
        }
    }
}