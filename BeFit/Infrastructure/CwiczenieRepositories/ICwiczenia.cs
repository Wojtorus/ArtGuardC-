using BeFit.Infrastructure.CwiczenieRepositories.DTO;
using BeFit.Models;

namespace BeFit.Infrastructure.CwiczenieRepositories
{
    public interface ICwiczenia
    {
        List<Cwiczenie> GetAll();
        Cwiczenie GetById(int id);
        public Cwiczenie CreateCwiczenie(CwiczenieDTO dto);
        public bool Delete(int id);
        public Cwiczenie? Edition(Cwiczenie cwiczenie);
    }
}
