using System.ComponentModel.DataAnnotations;

namespace SportsComplexApp.Data.Models;

public class Trainer
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }

    [Required]
    [MaxLength(50)]
    public string Specialization { get; set; }
    public DateTime HireDate { get; set; }

    public ICollection<TrainerSession> TrainersSessions { get; set; }

}