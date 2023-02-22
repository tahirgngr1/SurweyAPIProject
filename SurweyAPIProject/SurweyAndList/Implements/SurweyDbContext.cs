using Microsoft.EntityFrameworkCore;
using SurweyAndLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Implements
{
    public class SurweyDbContext : DbContext
    {
        public DbSet<Surwey> Surweys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SurweyAPIProject;Trusted_Connection=True;");
        } 
    }
}
