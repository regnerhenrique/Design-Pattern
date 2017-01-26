using RH.DesignPatterns.Interface;

namespace RH.DesignPatterns.Entities
{
    class Autorizado : IPreferencial
    {
        public bool Permitido()
        {
            return true;
        }
    }
}