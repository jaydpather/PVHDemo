using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ViewModel
{
    public class RegistrationViewModel
    {
        [Display(Name="First Name")]
        [Required]
        [StringLength(50, ErrorMessage = "Must be 50 characters or less")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "Must be 50 characters or less")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The Email Address field is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email Address")]
        [StringLength(150, ErrorMessage = "Must be 150 characters or less")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [StringLength(20, ErrorMessage = "Must be 20 characters or less")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        [StringLength(50, ErrorMessage = "Must be 50 characters or less")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address Line 2")]
        [StringLength(50, ErrorMessage = "Must be 50 characters or less")]
        public string AddressLine2 { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Must be 50 characters or less")]
        public string City { get; set; }

        [Required]
        [Display(Name = "State/Province")]
        [StringLength(50, ErrorMessage = "Must be 50 characters or less")]
        public string StateProvince { get; set; }

        [Required]
        [Display(Name = "Country")]
        [StringLength(50, ErrorMessage = "Must be 50 characters or less")]
        public string Country { get; set; }

        [Required]
        [Display(Name = "Postal Code")]
        [StringLength(20, ErrorMessage = "Must be 20 characters or less")]
        public string PostalCode { get; set; }

        [Display(Name ="Preferred Programming Language")]
        public int ProgrammingLanguageId { get; set; }

        public List<ProgrammingLanguageViewModel> ProgrammingLanguages { get; set; }

        [StringLength(250, ErrorMessage = "Must be 250 characters or less")]
        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }

        public string StatusMessage { get; set; }
    }
}
