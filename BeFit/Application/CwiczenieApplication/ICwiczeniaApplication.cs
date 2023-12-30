using BeFit.Infrastructure.CwiczenieRepositories.DTO;
using BeFit.Models;
using Microsoft.AspNetCore.Razor.Language.Intermediate;

namespace BeFit.Application.CwiczenieApplication.CwiczenieApplication
{
    public interface ICwiczeniaApplication
    {
        public Cwiczenie Create(CwiczenieDTO dto);

        List<Cwiczenie> GetAll();
        Cwiczenie GetById(int id);

        public bool Delete(int id);
        public Cwiczenie? Edition(Cwiczenie cwiczenie);
    }
}
