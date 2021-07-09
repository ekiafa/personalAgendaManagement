using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using personal_agenda_management.Data;
namespace personal_agenda_management.Models
{


    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new personal_agenda_managementContext(
                serviceProvider.GetRequiredService<DbContextOptions<personal_agenda_managementContext>>()))
            {
                if (context.People.Any())
                {
                    return;
                }
                context.People.AddRange(
                    new People
                    {
                        name = "Maria ",
                        phoneNumber = 746234567
                    }) ;
                context.SaveChanges();





            }
        }

    } 
}