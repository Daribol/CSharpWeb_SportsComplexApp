<<<<<<< HEAD
﻿namespace SportsComplexApp.Data;
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
=======
﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SportsComplexApp.Data;
using Microsoft.EntityFrameworkCore;
using Models;
public class SportsComplexDbContext : IdentityDbContext
{
    public SportsComplexDbContext(DbContextOptions<SportsComplexDbContext> options)
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
    public virtual DbSet<Tournament> Tournament { get; set; } = null!;
    public virtual DbSet<TournamentRegistration> TournamentRegistrations { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Reservation>()
            .HasKey(r => new { r.ClientId, r.SportId });
        builder.Entity<SpaReservation>()
            .HasKey(sr => new { sr.ClientId, sr.SpaServiceId });
        builder.Entity<TrainerSession>()
            .HasKey(ts => new { ts.ClientId, ts.TrainerId });
        builder.Entity<TournamentRegistration>()
            .HasKey(tr => new { tr.ClientId, tr.TournamentId });


        builder.Entity<SpaService>()
            .Property(ss => ss.Price)
            .HasPrecision(18, 2);
        builder.Entity<Sport>()
            .Property(s => s.Price)
            .HasPrecision(18, 2);
    }
>>>>>>> aa4ebc202dfbfd35654d1dcb4f4b39138255a65d
}