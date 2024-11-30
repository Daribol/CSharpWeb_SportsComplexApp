namespace SportsComplexApp.Common;

public class EntityValidationConstants
{
    public static class Facility
    {
        public const int NameMaxLength = 50;
        public const int NameMinLength = 2;
        public const int LocationMaxLength = 50;
        public const int LocationMinLength = 2;
        public const int CapacityMaxValue = 100;
        public const int CapacityMinValue = 2;
    }
    public static class Client
    {
        public const int NameMaxLength = 50;
        public const int NameMinLength = 2;
        public const int LastMaxLength = 50;
        public const int LastMinLength = 2;
        public const int GenderMaxLength = 10;
        public const int GenderMinLength = 2;
        public const string ClientDateOfBirth = "dd-MM-yyyy";
    }
    public static class SpaService
    {
        public const int NameMaxLength = 50;
        public const int NameMinLength = 5;
        public const int DescriptionMaxLength = 200;
        public const int DescriptionMinLength = 10;
        public const int DurationMaxValue = 120;
        public const int DurationMinValue = 30;
        public const decimal PriceMaxValue = 500.00m;
        public const decimal PriceMinValue = 30.00m;
        public const string SpaReservationDate = "dd-MM-yyyy HH:mm";
    }
    public static class Sport
    {
        public const int NameMaxLength = 50;
        public const int NameMinLength = 5;
        public const decimal MaxPriceValue = 500.00m;
        public const decimal MinPriceValue = 10.00m;
        public const string SportReservationDate = "dd-MM-yyyy HH:mm";
        public const int DurationMaxValue = 120;
        public const int DurationMinValue = 30;
    }
    public static class Trainer
    {
        public const int FirstNameMaxLength = 50;
        public const int FirstNameMinLength = 2;
        public const int LastNameMaxLength = 50;
        public const int LastNameMinLength = 5;
        public const int SpecializationMaxLength = 50;
        public const int SpecializationMinLength = 5;
        public const string TrainerHireDate = "dd-MM-yyyy";
        public const string TrainerSessionDate = "dd-MM-yyyy HH:mm";
        public const int DurationMaxValue = 120;
        public const int DurationMinValue = 30;
    }
    public static class Tournament
    {
        public const int NameMaxLength = 100;
        public const int NameMinLength = 5;
        public const int DescriptionMaxLength = 5000;
        public const int DescriptionMinLength = 10;
        public const int LocationMaxLength = 100;
        public const int LocationMinLength = 10;
        public const string TournamentStartDate = "dd-MM-yyyy HH:mm";
        public const string TournamentEndDate = "dd-MM-yyyy";
        public const decimal MaxPriceValue = 100.00m;
        public const decimal MinPriceValue = 10.00m;
    }
}