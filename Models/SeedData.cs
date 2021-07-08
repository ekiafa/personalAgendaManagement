using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personal_agenda_management.Models
{


    public class SeedData
    {
      public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new personal_agenda_managementContextModelSnapshot(
                serviceProvider.GetRequiredService<DbContextOptions<personal_agenda_managementContext>>()))
        }


    }
}