using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InteractiveCvAspCore.Models
{
    public class AbilityCategory
    {
        [Key]
        public int AbilityCategoryID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
