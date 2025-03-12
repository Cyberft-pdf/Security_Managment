using Microsoft.EntityFrameworkCore;
using SecurityIncidents.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityIncidents.Core
{
    public class SecurityIncidentsDbContext : DbContext
    {
        public DbSet<Incident> Incidents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection string
            optionsBuilder.UseMySQL("");
        }

    }
}
