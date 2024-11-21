using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsComplexApp.Data.Models;

public class Reservation
{
    [Key]
    public Guid Id { get; set; }

    [ForeignKey(nameof(Member))]
    public int MemberId { get; set; }
    public Member Member { get; set; }

    [ForeignKey(nameof(Sport))]
    public int SportId { get; set; }
    public Sport Sport { get; set; }

    public DateTime ReservationDate { get; set; }
    public TimeSpan ReservationTime { get; set; }

    public int Duration { get; set; }
}