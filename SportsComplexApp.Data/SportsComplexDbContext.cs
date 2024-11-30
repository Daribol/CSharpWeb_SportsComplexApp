namespace SportsComplexApp.Data;
using Microsoft.EntityFrameworkCore;
using SportsComplexApp.Data.Models;
public class SportsComplexDbContext : DbContext
{
    public SportsComplexDbContext()
    {

    }

    public SportsComplexDbContext(DbContextOptions options)
        :base(options)
    {

    }

    public virtual DbSet<Facility> Facility { get; set; } = null!;
    public virtual DbSet<Client> Clients { get; set; } = null!;
    public virtual DbSet<Reservation> Reservations { get; set; } = null!;
    public virtual DbSet<SpaReservation> SpaReservations { get; set; } = null!;
    public virtual DbSet<SpaService> SpaServices { get; set; } = null!;
    public virtual DbSet<Sport> Sports { get; set; } = null!;
    public virtual DbSet<Trainer> Trainers { get; set; } = null!;
    public virtual DbSet<TrainerSession> TrainersSessions { get; set; } = null!;
    public virtual DbSet<TournamentRegistration> TournamentRegistrations { get; set; } = null!;
    public virtual DbSet<Tournament> Tournaments { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Reservation>()
            .HasKey(r => new { r.ClientId ,r.SportId });
        builder.Entity<SpaReservation>()
            .HasKey(sr => new { sr.ClientId, sr.SpaServiceId });
        builder.Entity<TrainerSession>()
            .HasKey(ts => new { ts.ClientId, ts.TrainerId });
        builder.Entity<TournamentRegistration>()
            .HasKey(t => new { t.ClientId });

        builder.Entity<SpaService>()
            .Property(ss => ss.Price)
            .HasPrecision(18, 2);
        builder.Entity<Sport>()
            .Property(s=>s.Price)
            .HasPrecision(18, 2);
        builder.Entity<Tournament>()
            .Property(t => t.Price)
            .HasPrecision(18, 2);
    }
}