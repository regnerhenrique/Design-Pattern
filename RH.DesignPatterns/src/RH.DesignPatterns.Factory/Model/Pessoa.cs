namespace RH.DesignPatterns.Factory.Model
{
    public abstract class Pessoa
    {
        private string Nome { get; set; }
        private int Idade { get; set; }

        public string GetNome() { return Nome; }
        protected void SetNome(string nome) { Nome = nome; }
        public int GetIdade() { return Idade; }
        protected void SetIdade(int idade) { Idade = idade; }

        public abstract string MensagemTipoPessoa();
    }
}