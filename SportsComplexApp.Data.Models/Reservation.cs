using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;
namespace SportsComplexApp.Data.Models;

public class Reservation
{
    [ForeignKey(nameof(Client))] 
    public string ClientId { get; set; } = null!;
    public Client Client { get; set; } = null!;

    [ForeignKey(nameof(Sport))]
    public int SportId { get; set; }
    public Sport Sport { get; set; } = null!;
}