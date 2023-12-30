namespace BeFit.Models
{
    public class Uzytkownicy
    {
        public int id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Haslo { get; set; }
        public string Uprawnienia { get; set; } = "user";

        public List<SesjaTreningowa> ListaTreningow { get; set; } = new List<SesjaTreningowa>();
    }
}
