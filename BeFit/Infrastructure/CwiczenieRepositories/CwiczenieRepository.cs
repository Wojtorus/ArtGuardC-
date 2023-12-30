using AutoMapper;
using BeFit.Infrastructure.CwiczenieRepositories.DTO;
using BeFit.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BeFit.Infrastructure.CwiczenieRepositories
{
    public class CwiczenieRepository : ICwiczenia
    {
        private readonly BeFitDbContext _context;
        private readonly IMapper _mapper;

        public CwiczenieRepository(BeFitDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Cwiczenie> GetAll()
        {
            return _context.Cwiczenia.ToList();
        }

        public Cwiczenie GetById(int id)
        {
            return _context.Cwiczenia.Where(x => x.id == id).FirstOrDefault();
        }

        public Cwiczenie CreateCwiczenie(CwiczenieDTO dto)
        {
            var cwiczenie = _mapper.Map<Cwiczenie>(dto);
            _context.Cwiczenia.Add(cwiczenie);
            _context.SaveChanges();
            return cwiczenie;
        }

        public bool Delete(int id)
        {
           var cwiczenie = _context.Cwiczenia.FirstOrDefault(x => x.id == id);
            if(cwiczenie == null)
            {
                return false;
            }
           _context.Cwiczenia.Remove(cwiczenie);
           _context.SaveChanges();
            return true;
        }

        public Cwiczenie? Edition(Cwiczenie cwiczenie)
        {
            var szukaneCwiczenie = _context.Cwiczenia.FirstOrDefault(x => x.id == cwiczenie.id);
            if (szukaneCwiczenie == null)
            {
                return null;
            }
            szukaneCwiczenie.ObciazenieKg = cwiczenie.ObciazenieKg;
            szukaneCwiczenie.NazwaCwiczenia = cwiczenie.NazwaCwiczenia;
            _context.SaveChanges();
            return cwiczenie;
        }
    }
}
