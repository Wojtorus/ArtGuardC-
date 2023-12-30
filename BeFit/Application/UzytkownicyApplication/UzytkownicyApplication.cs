using BeFit.Infrastructure.UzytkownicyRespositories;
using BeFit.Infrastructure.UzytkownicyRespositories.DTO;
using BeFit.Models;

namespace BeFit.Application.UzytkownicyApplication
{
    public class UzytkownicyApplication : IUzytkownicyApplication
    {
        private readonly IUzytkownicyRespositories _uzytkownicy;

        public UzytkownicyApplication(IUzytkownicyRespositories uzytkownicy)
        {
            _uzytkownicy = uzytkownicy;
        }
        public Uzytkownicy DodawanieUzytkownika(UzytkownikDTO dto)
        {
            return _uzytkownicy.DodawanieUzytkownika(dto);
        }

        public Uzytkownicy? LogowanieUzytkownika(UzytkownikDTO dto)
        {
            return _uzytkownicy.LogowanieUzytkownika(dto);
        }
    }
}
