using ASa.ApartmentManagement.Core.ChargeCalculation.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ASa.ApartmentManagement.Core.ChargeCalculation.Repositories
{
    public interface IChargeRepository
    {
        Task AddAsync(Charge charge);
        Task AddRangeAsync(IEnumerable<Charge> charges);
        Task DeleteAllAfterDateAsync(DateTime from);
    }
}
