using RH.DesignPatterns.Factory.Model;

namespace RH.DesignPatterns.Factory.Factory
{
    public class FactoryPessoa
    {
        private readonly string _nome;
        private readonly int _idade;

        public FactoryPessoa(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        public Pessoa CriarPessoa()
        {
            if (_idade > 60)
                return new Idoso(_nome, _idade);

            return new Jovem(_nome, _idade);
        }
    }
}