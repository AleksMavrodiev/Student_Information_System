namespace StudentInformationSystem.Common
{
    public static class DataValidationConstants
    {
        public static class UniversityConstants
        {
            public const int NameMinLength = 10;
            public const int NameMaxLength = 50;
            public const int AddressMinLength = 10;
            public const int AddressMaxLength = 50;
            public const int PostCodeMinLength = 4;
            public const int PostCodeMaxLength = 10;
        }

        public static class FacultyConstants
        {
            public const int NameMinLength = 10;
            public const int NameMaxLength = 50;
        }

        public static class SpecialtyConstants
        {
            public const int NameMinLength = 10;
            public const int NameMaxLength = 80;
        }

        public static class StudentConstants
        {
            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 50;
            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 50;
            public const int EGNMaxLength = 10;
            public const int EmailMinLength = 10;
            public const int EmailMaxLength = 50;
            public const int FacultyNumberMinLength = 5;
            public const int FacultyNumberMaxLength = 10;
            public const int PhoneNumberMinLength = 5;
            public const int PhoneNumberMaxLength = 20;
        }

        public static class CourseConstants
        {
            public const int NameMinLength = 10;
            public const int NameMaxLength = 50;
            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 200;
            public const int CreditsMinValue = 1;
            public const int CreditsMaxValue = 20;
        }

        public static class TeacherConstants
        {
            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 50;
            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 50;
            public const int EGNMaxLength = 10;
            public const int EmailMinLength = 10;
            public const int EmailMaxLength = 50;
            public const int PhoneNumberMinLength = 5;
            public const int PhoneNumberMaxLength = 20;
        }
    }
}
