<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SportsComplexApp.Common.EntityValidationConstants.SpaReservation;

namespace SportsComplexApp.Data.Models;

public class SpaReservation
{
    [Key]
    public int Id { get; set; }


    [ForeignKey(nameof(Member))]
    public int MemberId { get; set; }
    public Member Member { get; set; } = null!;


    [ForeignKey(nameof(SpaService))]
    public int SpaServiceId { get; set; }
    public SpaService SpaService { get; set; } = null!;


    [Required]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = SpaReservationDate, ApplyFormatInEditMode = true)]
    public DateTime ReservationDate { get; set; }

    [Required]
    [Range(DurationMinValue, DurationMaxValue)]
    public int Duration { get; set; }

    [Required]
    [Range((double)TotalPriceMinValue, (double) TotalPriceMaxValue)]
    public decimal TotalPrice { get; set; }
=======
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SportsComplexApp.Common.EntityValidationConstants.SpaReservation;

namespace SportsComplexApp.Data.Models;

public class SpaReservation
{
    [Key]
    public int Id { get; set; }


    [ForeignKey(nameof(Member))]
    public int MemberId { get; set; }
    public Member Member { get; set; } = null!;


    [ForeignKey(nameof(SpaService))]
    public int SpaServiceId { get; set; }
    public SpaService SpaService { get; set; } = null!;


    [Required]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = SpaReservationDate, ApplyFormatInEditMode = true)]
    public DateTime ReservationDate { get; set; }

    [Required]
    [Range(DurationMinValue, DurationMaxValue)]
    public int Duration { get; set; }

    [Required]
    [Range((double)TotalPriceMinValue, (double) TotalPriceMaxValue)]
    public decimal TotalPrice { get; set; }
>>>>>>> aa4ebc202dfbfd35654d1dcb4f4b39138255a65d
}