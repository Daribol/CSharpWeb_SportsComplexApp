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
    public virtual DbSet<Member> Members { get; set; } = null!;
    public virtual DbSet<MembershipType> MembershipTypes { get; set; } = null!;
    public virtual DbSet<Reservation> Reservations { get; set; } = null!;
    public virtual DbSet<SpaReservation> SpaReservations { get; set; } = null!;
    public virtual DbSet<SpaService> SpaServices { get; set; } = null!;
    public virtual DbSet<Sport> Sports { get; set; } = null!;
    public virtual DbSet<Trainer> Trainers { get; set; } = null!;
    public virtual DbSet<TrainerSession> TrainersSession { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Member>()
            .HasKey(m => new { m.MembershipTypeId });
        builder.Entity<Reservation>()
            .HasKey(r => new { r.MemberId ,r.SportId });
        builder.Entity<SpaReservation>()
            .HasKey(sr => new { sr.MemberId, sr.SpaServiceId });
        builder.Entity<Sport>()
            .HasKey(s => new { s.FacilityId });
        builder.Entity<TrainerSession>()
            .HasKey(ts => new { ts.MemberId, ts.TrainerId });

        builder.Entity<MembershipType>()
            .Property(mt => mt.Price)
            .HasPrecision(18, 2);
        builder.Entity<SpaService>()
            .Property(ss => ss.Price)
            .HasPrecision(18, 2);
        builder.Entity<SpaReservation>()
            .Property(sr=>sr.TotalPrice)
            .HasPrecision(18, 2);
    }
}