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

    public static class Member
    {
        public const int NameMaxLength = 50;
        public const int NameMinLength = 2;

        public const int LastMaxLength = 50;
        public const int LastMinLength = 2;

        public const int GenderMaxLength = 10;
        public const int GenderMinLength = 2;

        public const string DateOfBirth = "dd-MM-yyyy";
    }

    public static class MembershipType
    {
        public const int TypeNameMaxLength = 20;
        public const int TypeNameMinLength = 2;

        public const int PriceMaxValue = 500;
        public const int PriceMinValue = 10;
    }

    public static class Reservation
    {
        public const string ReservationDate = "dd-MM-yyyy HH:mm";
        public const int DurationMaxValue = 120;
        public const int DurationMinValue = 30;
    }

    public static class SpaReservation
    {
        public const string SpaReservationDate = "dd-MM-yyyy HH:mm";

        public const int DurationMaxValue = 120;
        public const int DurationMinValue = 30;

        public const decimal TotalPriceMaxValue = 500.00m;
        public const decimal TotalPriceMinValue = 30.00m;
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
    }

    public static class Sport
    {
        public const int NameMaxLength = 50;
        public const int NameMinLength = 5;
    }

    public static class Trainer
    {
        public const int FirstNameMaxLength = 50;
        public const int FirstNameMinLength = 2;

        public const int LastNameMaxLength = 50;
        public const int LastNameMinLength = 5;

        public const int SpecializationMaxLength = 50;
        public const int SpecializationMinLength = 5;

        public const string HireDate = "dd-MM-yyyy";
    }

    public static class TrainerSession
    {
        public const string SessionDate = "dd-MM-yyyy HH:mm";
        public const int DurationMaxValue = 120;
        public const int DurationMinValue = 30;
    }
}