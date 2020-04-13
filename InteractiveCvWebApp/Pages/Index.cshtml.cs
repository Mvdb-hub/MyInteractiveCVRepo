using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InteractiveCvAspCore.Data;
using InteractiveCvAspCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace InteractiveCvWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly InteractiveCvContext _context;

        public IndexModel(InteractiveCvContext context)
        {
            _context = context;
        }


        public Person FirstPerson { get; set; }
        public int PersonAge { get; set; }

        public IEnumerable<AbilityCategory> AbilityCategories { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            FirstPerson = await _context.Person
                .Include(a => a.Abilities)
                .ThenInclude(c => c.Category).FirstOrDefaultAsync();

            FirstPerson.Educations = await _context.PersonEducation
                .Where(e => e.PersonID == FirstPerson.ID).OrderBy(e => e.StartDate).ToListAsync();

            FirstPerson.Experiences = await _context.PersonExperience
                .Where(e => e.PersonID == FirstPerson.ID).OrderBy(e => e.StartDate).ToListAsync();

            AbilityCategories = await _context.AbilityCategory.ToListAsync();

            PersonAge = 34; //create calculate age function in Person Model
            if (FirstPerson == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
