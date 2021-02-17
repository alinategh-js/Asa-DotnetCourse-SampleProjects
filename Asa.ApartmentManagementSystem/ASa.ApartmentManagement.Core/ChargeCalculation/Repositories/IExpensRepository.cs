using ASa.ApartmentManagement.Core.ChargeCalculation.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ASa.ApartmentManagement.Core.ChargeCalculation.Repositories
{
    public interface IExpensRepository
    {
        Task<IEnumerable<Expens>> GetAllByDateAsync(DateTime from, DateTime to);
    }
}
