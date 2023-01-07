using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MuseumTest.Domain.Entities;

namespace MuseumTest.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions <ApplicationDbContext> options): base (options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Museum> museums { get; set; }
        public DbSet<Article> articles { get; set; }

    }
}
