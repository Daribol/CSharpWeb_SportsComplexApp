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

        [Required]
        [Range((double)MinPriceValue, (double)MaxPriceValue)]
        public decimal Price { get; set; }

        [Required]
        public string? ImageUrl { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = SportReservationDate, ApplyFormatInEditMode = true)]
        public DateTime ReservationDate { get; set; }

        [Required]
        [Range(DurationMinValue, DurationMaxValue)]
        public int Duration { get; set; }


        public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    }
}
