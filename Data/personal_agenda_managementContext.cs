using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using personal_agenda_management.Models;

namespace personal_agenda_management.Data
{
    public class personal_agenda_managementContext : DbContext
    {
        public personal_agenda_managementContext (DbContextOptions<personal_agenda_managementContext> options)
            : base(options)
        {
        }

        public DbSet<personal_agenda_management.Models.People> People { get; set; }
    }
}
