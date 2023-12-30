using BeFit.Infrastructure.UzytkownicyRespositories.DTO;
using BeFit.Models;

namespace BeFit.Infrastructure.UzytkownicyRespositories
{
    public interface IUzytkownicyRespositories
    {
        Uzytkownicy DodawanieUzytkownika(UzytkownikDTO dto);
        Uzytkownicy? LogowanieUzytkownika(UzytkownikDTO dto);
    }
}