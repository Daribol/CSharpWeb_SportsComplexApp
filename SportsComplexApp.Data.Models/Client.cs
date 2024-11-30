using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SportsComplexApp.Common;
using static SportsComplexApp.Common.EntityValidationConstants.Client;

namespace SportsComplexApp.Data.Models;

public class Client
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(NameMaxLength)]
    public string FirstName { get; set; } = null!;

    [Required]
    [MaxLength(LastMaxLength)]
    public string LastName { get; set; } = null!;

    [Required]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = ClientDateOfBirth, ApplyFormatInEditMode = true)]
    public DateTime DateOfBirth { get; set; }

    [Required]
    [MaxLength(GenderMaxLength)]
    public string Gender { get; set; } = null!;

    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    public ICollection<TrainerSession> TrainerSession { get; set; } = new List<TrainerSession>();

    public ICollection<SpaReservation> SpaReservations { get; set; } = new List<SpaReservation>();

    public ICollection<TournamentRegistration> TournamentRegistrations { get; set; } = new List<TournamentRegistration>();
}