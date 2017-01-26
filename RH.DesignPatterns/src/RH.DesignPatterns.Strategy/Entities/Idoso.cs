namespace RH.DesignPatterns.Entities
{
    public class Idoso : Pessoa
    {
        public Idoso(string nome, int idade)
        {
            Name = nome;
            Idade = idade;
            Permissao = new Autorizado();
        }
    }
}