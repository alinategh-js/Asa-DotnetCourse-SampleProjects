using System;
using System.Collections.Generic;
using System.Text;

namespace ASa.ApartmentManagement.Core.ChargeCalculation.Repositories
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }
}
