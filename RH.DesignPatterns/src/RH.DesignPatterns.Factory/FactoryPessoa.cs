using RH.DesignPatterns.Factory.Entities;

namespace RH.DesignPatterns.Factory
{
    public class FactoryPessoa
    {
        public Pessoa CriarPessoa(int idade)
        {
            if (idade > 60){
                return new Idoso();

            }
            else{
                return new Jovem();
            }
        }
    }        
}