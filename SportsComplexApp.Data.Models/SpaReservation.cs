using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsComplexApp.Data.Models;

public class SpaReservation
{
    [Key]
    public Guid Id { get; set; }

    [ForeignKey(nameof(Member))]
    public int MemberId { get; set; }
    public Member Member { get; set; }

    [ForeignKey(nameof(SpaService))]
    public int SpaServiceId { get; set; }
    public SpaService SpaService { get; set; }

    public DateTime ReservationDate { get; set; }
    public TimeSpan ReservationTime { get; set; }

    public int Duration { get; set; }
    public decimal TotalPrice { get; set; }
}