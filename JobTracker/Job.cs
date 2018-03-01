using System;
using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        [Required]
        [StringLength(55, ErrorMessage = "Please shorten the job title to 55 characters")]
        public string Title { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public string Salary { get; set; }

        [StringLength(500, ErrorMessage = "Please shorten the job description to less than 500 characters.")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Company is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a company from list.")]
        [Display(Name = "Company")]
        public int CompanyId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a contact from list.")]
        [Display(Name = "Contact")]
        public int? ContactId { get; set; }

        public Company Company { get; set; }
        public Contact Contact { get; set; }
    }
}