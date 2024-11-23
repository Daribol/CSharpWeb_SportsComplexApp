using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SportsComplexApp.Common;
using static SportsComplexApp.Common.EntityValidationConstants.Reservation;

namespace SportsComplexApp.Data.Models;

public class Reservation
{
    [Key]
    public int Id { get; set; }


    [ForeignKey(nameof(Member))]
    public int MemberId { get; set; }
    public Member Member { get; set; } = null!;


    [ForeignKey(nameof(Sport))]
    public int SportId { get; set; }
    public Sport Sport { get; set; } = null!;


    [Required]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = EntityValidationConstants.Reservation.ReservationDate, ApplyFormatInEditMode = true)]
    public DateTime ReservationDate { get; set; }

    [Required]
    [Range(DurationMinValue, DurationMaxValue)]
    public int Duration { get; set; }
}