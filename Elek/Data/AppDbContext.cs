using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elek.Data;

namespace Elek.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
             : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Elek.Data.Movie> Movie { get; set; }
    }
}
