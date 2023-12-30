using Microsoft.EntityFrameworkCore;

namespace BeFit.Models
{
    public class BeFitDbContext : DbContext
    {
       public BeFitDbContext(DbContextOptions<BeFitDbContext> options): base(options)
        {

        }
        public DbSet<Cwiczenie> Cwiczenia { get; set; }
        public DbSet<Wynik> Wyniki { get; set; }
        public DbSet<Uzytkownicy> Uzytkownicy { get; set; }

        public DbSet<SesjaTreningowa> SesjeTreningowe { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wynik>().HasOne(x => x.NazwaCwiczenia).WithMany().HasForeignKey(x => x.IdNazwyCwiczenia);
            modelBuilder.Entity<SesjaTreningowa>().HasMany<Wynik>(x => x.CwiczeniaSesjiTreningowej).WithOne(x => x.SesjaTreningowa).HasForeignKey(x => x.IdSesjaTreningowa);
            modelBuilder.Entity<Uzytkownicy>().HasMany<SesjaTreningowa>(x => x.ListaTreningow).WithOne(x => x.Uzytkownik).HasForeignKey(x => x.IdUzytkownika);
        }
    }
}
