using ASa.ApartmentManagement.Core.ChargeCalculation.Domain;
using ASa.ApartmentManagement.Core.ChargeCalculation.Repositories;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Asa.ApartmentSystem.Infra.Repositories
{
    public class EfBuildingRepository : IBuildingRepository
    {
        ApartmentDbContext _dbContext;
        public EfBuildingRepository(ApartmentDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public Task<Building> GetBuildingAsync() => Task.Run(() => this._dbContext.Buildings.First());

    }
}
