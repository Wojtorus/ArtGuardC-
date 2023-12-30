namespace BeFit.Models
{
    public class SesjaTreningowa
    {
        public DateTime Data { get; set; } = DateTime.Now;
        public int id { get; set; }
        public List<Wynik> CwiczeniaSesjiTreningowej { get; set; } = new List<Wynik> { };

        public int IdUzytkownika { get; set; }
        public  Uzytkownicy Uzytkownik { get; set; }

    }
}
