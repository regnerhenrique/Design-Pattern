using RH.DesignPatterns.Interface;

namespace RH.DesignPatterns.Entities
{
    public abstract class Pessoa
    {
        public string Name { get; set; }
        public int Idade { get; set; }
        protected IPreferencial Permissao { get; set; }

        public bool PegarPreferencial()
        {
            return Permissao.Permitido();
        }
    }
}