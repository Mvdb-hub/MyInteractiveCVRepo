using InteractiveCvAspCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteractiveCvAspCore.Data
{
    public class DataSeeder
    {
        public static void Seed(InteractiveCvContext context)
        {
            // Look for any Person.
            if (context.Person.Any())
            {
                return;   // DB has been seeded
            }

            var person = new Person { Name = "Full Name", Birthday = DateTime.Parse("1986-03-14"), AboutMe = "About me text", Location = "City, Country", EmailAddress = "Emailaddress" };
            context.Person.Add(person);
            context.SaveChanges();

            var education = new PersonEducation { PersonID = 1, SchoolName = "School Name", Course = "Course Title",Description="Course Description", Location = "City, Country", StartDate = DateTime.Parse("2010-09-01"), EndDate = DateTime.Parse("2013-6-30") };
            context.PersonEducation.Add(education);
            context.SaveChanges();

            var experience = new PersonExperience { PersonID = 1, CompanyName = "Company Name", Function = "Function Title", Location = "City, Country", StartDate = DateTime.Parse("2013-09-01"), EndDate = DateTime.Parse("2015-6-30"), WebsiteUrl = "www.company.be", Description = "Function Description" };
            context.PersonExperience.Add(experience);
            context.SaveChanges();

            var categories = new AbilityCategory[]
            {
                new AbilityCategory{Description="Skills"},
                new AbilityCategory{Description="Tools"}
            };
            foreach (AbilityCategory c in categories)
            {
                context.AbilityCategory.Add(c);
            }
            context.SaveChanges();

            var abilities = new PersonAbility[]
            {
                new PersonAbility{PersonID = 1,AbilityCategoryID=1,Description="SQL",Score=3},
                new PersonAbility{PersonID = 1,AbilityCategoryID=1,Description="C#",Score=4},
                new PersonAbility{PersonID = 1,AbilityCategoryID=1,Description="HTML(5)",Score=3},
                new PersonAbility{PersonID = 1,AbilityCategoryID=1,Description="CSS",Score=3},
                new PersonAbility{PersonID = 1,AbilityCategoryID=1,Description="Java",Score=3},
                new PersonAbility{PersonID = 1,AbilityCategoryID=1,Description="Bootstrap Framework",Score=2},
                new PersonAbility{PersonID = 1,AbilityCategoryID=2,Description="Visual Studio",Score=3},
                new PersonAbility{PersonID = 1,AbilityCategoryID=2,Description="GitHub",Score=2},
                new PersonAbility{PersonID = 1,AbilityCategoryID=2,Description="Microsoft Office",Score=3},
                new PersonAbility{PersonID = 1,AbilityCategoryID=2,Description="SQL Server",Score=2},
                new PersonAbility{PersonID = 1,AbilityCategoryID=2,Description="Windows Powershell",Score=2}
            };
            foreach (PersonAbility p in abilities)
            {
                context.PersonAbility.Add(p);
            }
            context.SaveChanges();
        }
    }
}
