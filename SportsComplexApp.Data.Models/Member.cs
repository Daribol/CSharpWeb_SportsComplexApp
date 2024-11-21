using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsComplexApp.Data.Models;

public class Member
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    [MaxLength(10)]
    public string Gender { get; set; }

    [ForeignKey(nameof(MembershipType))]
    public int MembershipTypeId { get; set; }
    public MembershipType MembershipType { get; set; }

    public ICollection<Reservation> Reservations { get; set; }
    public ICollection<TrainerSession> TrainerSession { get; set; }
}