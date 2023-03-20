using FilmeAPI.Models;

using Microsoft.EntityFrameworkCore;

namespace FilmeAPI.Data;

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> opts) : base(opts)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sessao>()
            .HasKey(s => new { s.FilmeId, s.CinemaId });

        modelBuilder.Entity<Sessao>()
            .HasOne(s => s.Cinema)
            .WithMany(c => c.Sessoes)
            .HasForeignKey(s => s.CinemaId);

        modelBuilder.Entity<Sessao>()
            .HasOne(s => s.Filme)
            .WithMany(f => f.Sessoes)
            .HasForeignKey(s => s.FilmeId);

        modelBuilder.Entity<Endereco>()
            .HasOne(e => e.Cinema)
            .WithOne(c => c.Endereco)
            .OnDelete(DeleteBehavior.Restrict);
    }

    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Sessao> Sessoes { get; set; }
}
