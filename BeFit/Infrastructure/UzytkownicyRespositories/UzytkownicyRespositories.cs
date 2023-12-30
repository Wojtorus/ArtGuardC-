using AutoMapper;
using BeFit.Infrastructure.UzytkownicyRespositories.DTO;
using BeFit.Models;

namespace BeFit.Infrastructure.UzytkownicyRespositories
{
    public class UzytkownicyRespositories : IUzytkownicyRespositories
    {
        private readonly BeFitDbContext _context;
        private readonly IMapper _mapper;

        public UzytkownicyRespositories(BeFitDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Uzytkownicy DodawanieUzytkownika(UzytkownikDTO dto)
        {
            var uzytkownik = _mapper.Map<Uzytkownicy>(dto);
            _context.Uzytkownicy.Add(uzytkownik);
            _context.SaveChanges();
            return uzytkownik;
        }

        public Uzytkownicy? LogowanieUzytkownika(UzytkownikDTO dto)
        {
            var uzytkownik = _context.Uzytkownicy.FirstOrDefault(x => x.Nazwisko == dto.Nazwisko && x.Haslo == dto.Haslo && x.Imie == dto.Imie);
            if(uzytkownik == null)
            {
                return null;
            }
            return uzytkownik;
        }
    }
}
