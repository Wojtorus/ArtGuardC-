using BeFit.Application.CwiczenieApplication.CwiczenieApplication;
using BeFit.Infrastructure.CwiczenieRepositories;
using BeFit.Infrastructure.CwiczenieRepositories.DTO;
using BeFit.Models;

namespace BeFit.Application.CwiczenieApplication
{
    public class CwiczeniaApplication : ICwiczeniaApplication
    {
        private readonly ICwiczenia _cwiczeniaRespository;

        public CwiczeniaApplication( ICwiczenia cwiczeniaRespository)
        {
            _cwiczeniaRespository = cwiczeniaRespository;
        }
        public Cwiczenie Create(CwiczenieDTO dto)
        {
            return _cwiczeniaRespository.CreateCwiczenie(dto);
        }

        public bool Delete(int id)
        {
            return _cwiczeniaRespository.Delete(id);
        }

        public Cwiczenie? Edition(Cwiczenie cwiczenie)
        {
           return _cwiczeniaRespository.Edition(cwiczenie);
        }

        public List<Cwiczenie> GetAll()
        {
            return _cwiczeniaRespository.GetAll();
        }

        public Cwiczenie GetById(int id)
        {
            return _cwiczeniaRespository.GetById(id);
        }
    }
}
