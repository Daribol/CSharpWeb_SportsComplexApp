using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SportsComplexApp.Common;
using static SportsComplexApp.Common.EntityValidationConstants.TrainerSession;

namespace SportsComplexApp.Data.Models;

public class TrainerSession
{
    [Key]
    public int Id { get; set; }


    [ForeignKey(nameof(Trainer))]
    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; } = null!;


    [ForeignKey(nameof(Member))]
    public int MemberId { get; set; }
    public Member Member { get; set; } = null!;

    [Required]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = EntityValidationConstants.TrainerSession.SessionDate, ApplyFormatInEditMode = true)]
    public DateTime SessionDate { get; set; }

    [Required]
    [Range(DurationMinValue, DurationMaxValue)]
    public int Duration { get; set; }
}