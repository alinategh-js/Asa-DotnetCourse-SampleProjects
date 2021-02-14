using ASa.ApartmentManagement.Core.ChargeCalculation.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asa.ApartmentSystem.Infra.Repositories
{
    public class ApartmentDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("ConnectionString");//TODO : put CNX here
        }

        public DbSet<Building> Buildings { get; set; }
    }
}
