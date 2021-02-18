using ASa.ApartmentManagement.Core.ChargeCalculation.Domain;
using ASa.ApartmentManagement.Core.ChargeCalculation.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Asa.ApartmentSystem.Infra.Repositories
{
    public class ApartmentDbContext : DbContext,IUnitOfWork
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("ConnectionString");//TODO : put CNX here
        }

        public Task Commit() => this.SaveChangesAsync();
        


        public DbSet<Building> Buildings { get; set; }
        public DbSet<Charge> Charges { get; set; }
        public DbSet<Expens> Expenses { get; set; }

        public IBuildingRepository BuildingRepository => new EfBuildingRepository(this);

        public IExpensRepository ExpensRepository => new EfExpensRepository(this);

        public IChargeRepository ChargeRepository => new EfChargeRepository(this);
    }
}
