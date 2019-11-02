using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P01_HospitalDatabase.Data.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [Required]
        [MaxLength(DataValidation.Doctor.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(DataValidation.Doctor.MaxSpecialtyLength)]
        public string Specialty { get; set; }

        public ICollection<Visitation> Visitations { get; set; } = new HashSet<Visitation>();
    }
}
