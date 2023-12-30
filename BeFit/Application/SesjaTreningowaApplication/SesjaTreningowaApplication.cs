using BeFit.Infrastructure.SesjaTreningowaRespositories;
using BeFit.Infrastructure.SesjaTreningowaRespositories.DTO;
using BeFit.Models;

namespace BeFit.Application.SesjaTreningowaApplication
{
    public class SesjaTreningowaApplication : ISesjaTreningowaApplication
    {
        private readonly ISesjaTreningowaRepository _sesjaTreningowa;

        public SesjaTreningowaApplication(ISesjaTreningowaRepository sesjaTreningowa)
        {
            _sesjaTreningowa = sesjaTreningowa;
        }
        public SesjaTreningowa? DodajSesjeTreningowa(int IdUzytkownika)
        {
            var sesjaTreningowa = _sesjaTreningowa.DodajSesjeTreningowa(IdUzytkownika);
            return sesjaTreningowa;
        }
        public bool UsunSesjeTreningowa(int id)
        {
            var sesjaTreningowa = _sesjaTreningowa.UsunSesjeTreningowa(id);
            return sesjaTreningowa;
        }
        public SesjaTreningowa? EdytowanieSesjiTreningowej(SesjaTreningowaDTO dto)
        {
            var sesjaTreningowa = _sesjaTreningowa.EdytowanieSesjiTreningowej(dto);
            return sesjaTreningowa;
        }
    }
}
