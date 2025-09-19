using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BalanzaDigitalUg.Web.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<TipoMaterial> TipoMateriales { get; set; }
    public DbSet<Tamanio> Tamanios { get; set; }
    public DbSet<MaterialReciclado> MaterialesReciclados { get; set; }
    public DbSet<Registros> Registros { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TipoMaterial>().HasData(
            new TipoMaterial { Id = 1, Nombre = "Plástico" },
            new TipoMaterial { Id = 2, Nombre = "Vidrio" },
            new TipoMaterial { Id = 3, Nombre = "Metal" },
            new TipoMaterial { Id = 4, Nombre = "Papel" },
            new TipoMaterial { Id = 5, Nombre = "Otro" }
        );

        modelBuilder.Entity<Tamanio>().HasData(
            new Tamanio { Id = 1, Nombre = "Pequeño", RangoAlturaAnchura = "0-10 cm alto y 0-10 cm ancho" },
            new Tamanio { Id = 2, Nombre = "Mediano", RangoAlturaAnchura = "10-20 cm alto y 10-20 cm ancho" },
            new Tamanio { Id = 3, Nombre = "Grande", RangoAlturaAnchura = "20+ cm alto y 20+ cm ancho" }
        );

        modelBuilder.Entity<MaterialReciclado>()
            .HasOne(m => m.Tipo)
            .WithMany(t => t.MaterialesReciclados)
            .HasForeignKey(m => m.TipoId);

        modelBuilder.Entity<MaterialReciclado>()
            .HasOne(m => m.Tamanio)
            .WithMany(t => t.MaterialesReciclados)
            .HasForeignKey(m => m.TamanioId);

        modelBuilder.Entity<Registros>()
            .Property(r => r.ProcesadoEnAppWeb)
            .HasDefaultValue(false);
    }
}