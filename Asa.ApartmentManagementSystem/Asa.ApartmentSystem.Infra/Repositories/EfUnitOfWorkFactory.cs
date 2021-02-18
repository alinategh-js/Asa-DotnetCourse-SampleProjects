using ASa.ApartmentManagement.Core.ChargeCalculation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Asa.ApartmentSystem.Infra.Repositories
{
    public class EfUnitOfWorkFactory : IUnitOfWorkFactory
    {
        public IUnitOfWork Create() => new ApartmentDbContext();
        
    }
}
