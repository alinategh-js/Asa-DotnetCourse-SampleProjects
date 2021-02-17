using ASa.ApartmentManagement.Core.ChargeCalculation.Domain;
using ASa.ApartmentManagement.Core.ChargeCalculation.Repositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Asa.ApartmentSystem.Infra.Repositories
{
    public class EfChargeRepository : IChargeRepository
    {
        ApartmentDbContext _dbContex;
        public EfChargeRepository(ApartmentDbContext dbContex)
        {
            _dbContex = dbContex;
        }
        public Task AddAsync(Charge charge)
        {
            _dbContex.Charges.Add(charge);
            return Task.CompletedTask;
        }

        public Task DeleteAllAfterDateAsync(DateTime from)
        {
            _dbContex.Charges.RemoveRange(_dbContex.Charges.Where(x => x.IssueDate >= from));
            return Task.CompletedTask;
        }
    }
}
