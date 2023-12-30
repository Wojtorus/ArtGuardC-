using BeFit.Infrastructure.UzytkownicyRespositories.DTO;
using BeFit.Models;

namespace BeFit.Application.UzytkownicyApplication
{
    public interface IUzytkownicyApplication
    {
        Uzytkownicy DodawanieUzytkownika(UzytkownikDTO dto);
        Uzytkownicy? LogowanieUzytkownika(UzytkownikDTO dto);
    }
}