using BeFit.Infrastructure.SesjaTreningowaRespositories.DTO;
using BeFit.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace BeFit.Infrastructure.SesjaTreningowaRespositories
{
    public class SesjaTreningowaRepository : ISesjaTreningowaRepository
    {
        private readonly BeFitDbContext _context;

        public SesjaTreningowaRepository(BeFitDbContext context)
        {
            _context = context;
        }
        public SesjaTreningowa? DodajSesjeTreningowa(int IdUzytkownika)
        {
            var uzytkownik = _context.Uzytkownicy.FirstOrDefault(x => x.id == IdUzytkownika);
            if (uzytkownik == null)
            {
                return null;
            }
            var sesjaTreningowa = new SesjaTreningowa()
            {
                Uzytkownik = uzytkownik,
                IdUzytkownika = IdUzytkownika,
            };
            _context.SesjeTreningowe.Add(sesjaTreningowa);
            _context.SaveChanges();
            return sesjaTreningowa;
        }
        public bool UsunSesjeTreningowa(int id)
        {
            var sesjaTreningowa = _context.SesjeTreningowe.Include(x => x.CwiczeniaSesjiTreningowej).FirstOrDefault(x => x.id == id);
            if (sesjaTreningowa == null)
            {
                return false;
            }
            _context.SesjeTreningowe.Remove(sesjaTreningowa);
            _context.SaveChanges();
            return true;
        }
        public SesjaTreningowa? EdytowanieSesjiTreningowej(SesjaTreningowaDTO dto)
        {
            var sesjaTreningowa = _context.SesjeTreningowe.Include(x => x.CwiczeniaSesjiTreningowej).FirstOrDefault(x => x.id == dto.IdNazwyCwiczenia);
            if (sesjaTreningowa == null)
            {
                return null;
            }
            var cwiczenie = _context.Cwiczenia.FirstOrDefault(x => x.id == dto.IdNazwyCwiczenia);
            if (cwiczenie == null)
            {
                return null;
            }
            var wynik = sesjaTreningowa.CwiczeniaSesjiTreningowej.FirstOrDefault(x => x.id == dto.WynikId);
            if (wynik == null)
            {
                return null;
            }
            wynik.LiczbaSerii = dto.LiczbaSerii;
            wynik.NazwaCwiczenia = cwiczenie;
            wynik.LiczbaPowtorzenWSerii = dto.LiczbaPowtorzenWSerii;
            wynik.IdNazwyCwiczenia = dto.IdNazwyCwiczenia;
            _context.SaveChanges();
            return sesjaTreningowa;
        }
    }
}
