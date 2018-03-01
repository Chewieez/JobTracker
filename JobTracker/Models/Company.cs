using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracker.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Please shorten the company name")]
        public string Name { get; set; }

        [Required]
        [StringLength(55)]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}
