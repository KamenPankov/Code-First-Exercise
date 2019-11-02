using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_HospitalDatabase.Data.Models
{
    public class Patient
    {
        [Key]        
        public int PatientId { get; set; }

        [Required]
        [MaxLength(DataValidation.Patient.NameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(DataValidation.Patient.NameMaxLength)]
        public string LastName { get; set; }

        [MaxLength(DataValidation.Patient.AddresseMaxLength)]
        public string Address { get; set; }
       
        [Column(TypeName = DataValidation.Patient.EmailMaxLength)]
        public string Email { get; set; }

        [Required]
        public bool HasInsurance { get; set; }

        public ICollection<Visitation> Visitations { get; set; } = new HashSet<Visitation>();

        public ICollection<Diagnose> Diagnoses { get; set; }

        public ICollection<PatientMedicament> Prescriptions { get; set; }
    }
}
