using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InteractiveCvAspCore.Models
{
    public class PersonEducation
    {
        [Key]
        public int PersonEducationID { get; set; }

        [Required]
        public int PersonID { get; set; }

        [Required]
        [MaxLength(150)]
        public string SchoolName { get; set; }

        [Required]
        [MaxLength(150)]
        public string Course { get; set; }

        [Required]
        [MaxLength(50)]
        public string Location { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public Person Person { get; set; }
    }
}
