using EFWorkforce.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFWorkforce.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Employee> Employee { get; set; }

        //reflect our tables in our database, has to be called the same thing as database table

        public DbSet<Department> Department { get; set; }

        public DbSet<Computer> Computer { get; set; }
    }
}
