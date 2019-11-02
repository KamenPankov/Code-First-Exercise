using System;
using System.Collections.Generic;
using System.Text;

namespace P01_HospitalDatabase.Data
{
    public static class DataValidation
    {
        public static class Patient
        {
            public const int NameMaxLength = 50;
                       
            public const int AddresseMaxLength = 80;

            public const string EmailMaxLength = "varchar(250)";
        }

        public static class Visitation
        {
            public const int MaxCommentLength = 250;
        }

        public static class Doctor
        {
            public const int MaxNameLength = 100;

            public const int MaxSpecialtyLength = 100;
        }

        public static class Diagnose
        {
            public const int MaxNameLength = 50;

            public const int MaxCommentsLength = 250;
        }

        public static class Medicament
        {
            public const int MaxNameLength = 50;
        }
    }
}
