using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ASa.ApartmentManagement.Core.ChargeCalculation.Repositories
{
    public interface IUnitOfWork:IDisposable
    {
        Task Commit();
        IBuildingRepository BuildingRepository { get; }
        IExpensRepository ExpensRepository { get; }
        IChargeRepository ChargeRepository { get; }
    }
}
