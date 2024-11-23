using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SportsComplexApp.Common.EntityValidationConstants.Sport;

namespace SportsComplexApp.Data.Models
{
    public class Sport
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;


        [ForeignKey(nameof(Facility))]
        public int FacilityId { get; set; }
        public Facility Facility { get; set; } = null!;


        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    }
}
