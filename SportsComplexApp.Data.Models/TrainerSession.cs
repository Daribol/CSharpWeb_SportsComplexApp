using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsComplexApp.Data.Models;

public class TrainerSession
{
    [Key]
    public Guid Id { get; set; }


    [ForeignKey(nameof(Trainer))]
    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; }


    [ForeignKey(nameof(Member))]
    public int MemberId { get; set; }
    public Member Member { get; set; }


    public DateTime SessionDate { get; set; }
    public TimeSpan SessionTime { get; set; }


    public int Duration { get; set; }
}