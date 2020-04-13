using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InteractiveCvAspCore.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        [MaxLength(50)]
        public string Location { get; set; }

        [Required]
        public string AboutMe { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        [MaxLength(100)]
        public string EmailAddress { get; set; }

        [MaxLength(150)]
        public string TwitterUrl { get; set; }

        [MaxLength(150)]
        public string LinkedInUrl { get; set; }

        public ICollection<PersonExperience> Experiences { get; set; }
        public ICollection<PersonAbility> Abilities { get; set; }
        public ICollection<PersonEducation> Educations { get; set; }
    }
 
}

