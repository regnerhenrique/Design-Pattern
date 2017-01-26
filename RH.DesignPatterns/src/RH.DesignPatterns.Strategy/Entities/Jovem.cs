namespace RH.DesignPatterns.Entities
{
    public class Jovem : Pessoa
    {
        public Jovem(string nome, int idade)
        {
            Name = nome;
            Idade = idade;
            Permissao = new NaoAutorizado();
        }
    }
}