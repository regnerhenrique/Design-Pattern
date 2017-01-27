namespace RH.DesignPatterns.Factory.Entities
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public int  Idade { get; set; }

        public abstract string mensagemTipoPessoa();
    }
}