using System;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class RegistrationModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(150)]
        public string EmailAddress { get; set; }

        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string AddressLine1 { get; set; }

        [MaxLength(50)]
        public string AddressLine2 { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [MaxLength(50)]
        public string StateProvince { get; set; }

        [Required]
        [MaxLength(50)]
        public string Country { get; set; }

        [Required]
        [MaxLength(20)]
        public string PostalCode { get; set; }

        [Required]
        public int ProgrammingLanguageId { get; set; }

        public ProgrammingLanguageModel ProgrammingLanguage { get; set; }

        [MaxLength(250)]
        public string Comments { get; set; }
    }
}
