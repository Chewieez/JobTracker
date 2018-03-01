using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(30, ErrorMessage = "Please shorten the name.")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(30, ErrorMessage = "Please shorten the name.")]
        public string LastName { get; set; }

        
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "The phone number is too long or too short.")]
        public string PhoneNum { get; set; }
        
        
        [Display(Name = "Email Address")]
        [StringLength(40, ErrorMessage = "Please shorten the job description to less than 500 characters.")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }

    }
}