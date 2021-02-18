using Asa.Draft.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asa.Draft.EF
{
    public class StudentDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["AppartmentManagementCNX"].ConnectionString;
            optionsBuilder.UseLazyLoadingProxies()
                          .UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //new StudentEntityTypeConfiguration().Configure(modelBuilder.Entity<Student>());

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudentDbContext).Assembly);

            /*
            //Approach 1 for readonly list;
            var navigation=modelBuilder.Entity<Teacher>().Metadata.FindNavigation(nameof(Teacher.Students));
            navigation.SetPropertyAccessMode(PropertyAccessMode.Field);
            */
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
