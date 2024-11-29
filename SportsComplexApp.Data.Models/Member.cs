using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SportsComplexApp.Common;
using static SportsComplexApp.Common.EntityValidationConstants.Member;

namespace SportsComplexApp.Data.Models;

public class Member
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
    [DisplayFormat(DataFormatString = EntityValidationConstants.Member.DateOfBirth, ApplyFormatInEditMode = true)]
    public DateTime DateOfBirth { get; set; }

    [Required]
    [MaxLength(GenderMaxLength)]
    public string Gender { get; set; } = null!;


    [ForeignKey(nameof(MembershipType))]
    public int MembershipTypeId { get; set; }
    public MembershipType MembershipType { get; set; } = null!;


    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    public ICollection<TrainerSession> TrainerSession { get; set; } = new List<TrainerSession>();
}