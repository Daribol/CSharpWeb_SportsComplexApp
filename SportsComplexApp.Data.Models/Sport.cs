namespace SportsComplexApp.Data.Models
{
    public class Sport
    {
        public Sport()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int facility_id { get; set; }


    }
}
