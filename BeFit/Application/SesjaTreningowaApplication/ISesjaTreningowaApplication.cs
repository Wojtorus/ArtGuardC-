using BeFit.Infrastructure.SesjaTreningowaRespositories.DTO;
using BeFit.Models;

namespace BeFit.Application.SesjaTreningowaApplication
{
    public interface ISesjaTreningowaApplication
    {
        SesjaTreningowa? DodajSesjeTreningowa(int IdUzytkownika);
        SesjaTreningowa? EdytowanieSesjiTreningowej(SesjaTreningowaDTO dto);
        bool UsunSesjeTreningowa(int id);
    }
}