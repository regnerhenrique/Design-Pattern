using RH.DesignPatterns.Interface;

namespace RH.DesignPatterns.Entities
{
    class NaoAutorizado : IPreferencial
    {
        public bool Permitido()
        {
            return false;
        }
    }
}