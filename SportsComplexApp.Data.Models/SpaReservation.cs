using System.ComponentModel.DataAnnotations.Schema;

namespace SportsComplexApp.Data.Models;

public class SpaReservation
{
    [ForeignKey(nameof(Client))]
    public string ClientId { get; set; } = null!;
    public Client Client { get; set; } = null!;


    [ForeignKey(nameof(SpaService))]
    public int SpaServiceId { get; set; }
    public SpaService SpaService { get; set; } = null!;
}