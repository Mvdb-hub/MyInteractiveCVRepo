using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InteractiveCvAspCore.Models
{
    public class PersonAbility
    {
        [Key]
        public int PersonAbilityID { get; set; }

        [Required]
        public int PersonID { get; set; }

        [Required]
        public int AbilityCategoryID { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Score { get; set; }

        [Required]
        public Person Person { get; set; }

        [Required]
        public AbilityCategory Category { get; set; }
    }
}
