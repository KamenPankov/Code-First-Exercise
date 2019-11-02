using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P01_HospitalDatabase.Data.Models
{
    public class Diagnose
    {

        public int DiagnoseId { get; set; }

        [Required]
        [MaxLength(DataValidation.Diagnose.MaxNameLength)]
        public string Name { get; set; }

        [MaxLength(DataValidation.Diagnose.MaxCommentsLength)]
        public string Comments { get; set; }

        [Required]
        public int PatientId { get; set; }

        public Patient Patient { get; set; }
    }
}
