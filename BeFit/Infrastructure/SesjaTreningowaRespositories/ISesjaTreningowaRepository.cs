using BeFit.Infrastructure.SesjaTreningowaRespositories.DTO;
using BeFit.Models;

namespace BeFit.Infrastructure.SesjaTreningowaRespositories
{
    public interface ISesjaTreningowaRepository
    {
        SesjaTreningowa? DodajSesjeTreningowa(int IdUzytkownika);
        SesjaTreningowa? EdytowanieSesjiTreningowej(SesjaTreningowaDTO dto);
        bool UsunSesjeTreningowa(int id);
    }
}