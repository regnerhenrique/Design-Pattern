namespace RH.DesignPatterns.Observer.Entities
{
    public abstract class Observador
    {
        protected string Nome { private get; set; }
        protected float PrecoChopp { private get; set; }

        public string GetNome()
        {
            return Nome;
        }

        public float GetPrecoChopp()
        {
            return PrecoChopp;
        }
    }
}