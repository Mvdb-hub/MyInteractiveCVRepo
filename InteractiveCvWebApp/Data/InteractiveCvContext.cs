using InteractiveCvAspCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteractiveCvAspCore.Data
{
    public class InteractiveCvContext: DbContext
    {
        public InteractiveCvContext(DbContextOptions<InteractiveCvContext> options):base (options)
        {

        }
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonEducation> PersonEducation { get; set; }
        public DbSet<PersonExperience> PersonExperience { get; set; }
        public DbSet<PersonAbility> PersonAbility { get; set; }
        public DbSet<AbilityCategory> AbilityCategory { get; set; }
    }
}
