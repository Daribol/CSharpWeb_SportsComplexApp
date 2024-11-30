using SportsComplex.Web.ViewModels.Facility;

namespace SportsComplex.Web.ViewModels.Sport;

public class SportsDetailsViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? ImageUrl { get; set; }

    public FacilityViewModel Facility { get; set; }
}