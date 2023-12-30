namespace BeFit.Models
{
    public class Wynik
    {
        public int id { get; set; }
        public int LiczbaSerii { get; set; } = default;
        public int LiczbaPowtorzenWSerii { get; set; } = default;
        public int IdNazwyCwiczenia { get; set; }
        public Cwiczenie NazwaCwiczenia { get; set; }

        public int IdSesjaTreningowa { get; set; }
        public SesjaTreningowa SesjaTreningowa { get; set; }
    }
}

