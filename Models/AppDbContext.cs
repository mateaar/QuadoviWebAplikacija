using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace QuadoviWebAplikacija.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Bicikl> Bicikl { get; set; }
        public DbSet<Kategorija> Kategorija { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Bicikl>().Property(f => f.Cijena).HasPrecision(10, 2);

            modelBuilder.Entity<Kategorija>().HasData(
                new Kategorija() { Id = 1, Naziv = "Brdski" },
                new Kategorija() { Id= 2, Naziv = "Cestovni" },
                new Kategorija() { Id = 3, Naziv = "Trekking" },
                new Kategorija() { Id = 4, Naziv = "Hybrid" },
                new Kategorija() { Id = 5, Naziv = "Hard-tail" });
            modelBuilder.Entity<Bicikl>().HasData(
    new Bicikl() { Id = 1, Naziv = "BRDSKI BICIKL ST 120 27,5 ZA TOURING", Cijena = 320m, GodinaProizvodnje = 2019, SlikaUrl = "https://contents.mediadecathlon.com/p1995217/k$b4ef0580aa6bfc79383a35225fe4f3ff/brdski-bicikl-st-120-275quote-crno-plavi.jpg?format=auto&quality=40&f=800x800", KategorijaId = 1 },
    new Bicikl() { Id = 2, Naziv = "CESTOVNI BICIKL RC120 DISC", Cijena = 519m, GodinaProizvodnje = 2021, SlikaUrl = "https://contents.mediadecathlon.com/p2021839/k$9ef77d1c20368b5fd1bd0e44805b47a6/cestovni-bicikl-rc120-disc-tamnoplavo-narancasti.jpg?format=auto&quality=40&f=800x800", KategorijaId = 2 },
    new Bicikl() { Id = 3, Naziv = "Genesis SPEED CROSS SX 4.1 W", Cijena = 679m, GodinaProizvodnje = 2023, SlikaUrl = "https://www.intersport.hr/media/catalog/product/cache/382907d7f48ae2519bf16cd5f39b77f9/1/9/190550315_00_1.jpg", KategorijaId = 3 },
    new Bicikl() { Id = 4, Naziv = "HIBRIDNI BICIKL RIVERSIDE 500", Cijena = 379m, GodinaProizvodnje = 2023, SlikaUrl = "https://contents.mediadecathlon.com/p1990168/k$d69656b3c8efb170d8a772bb2f3f3481/hibridni-bicikl-riverside-500-plavi.jpg?format=auto&quality=40&f=800x800", KategorijaId = 4 },
    new Bicikl() { Id = 5, Naziv = " FUJI Nevada 29 1.7", Cijena = 588m, GodinaProizvodnje =2023, SlikaUrl = "https://www.rog-joma.hr/fajlovi/artikli_slike/1610038342.jpg", KategorijaId = 5 }
    );



        }
    }
}
