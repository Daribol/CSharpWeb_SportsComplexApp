using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace SportsComplexApp.Data.Models;

public class SpaReservation
{
    [ForeignKey(nameof(Client))]
    public string ClientId { get; set; } = null!;
    public IdentityUser Client { get; set; } = null!;


    [ForeignKey(nameof(SpaService))]
    public int SpaServiceId { get; set; }
    public SpaService SpaService { get; set; } = null!;
}