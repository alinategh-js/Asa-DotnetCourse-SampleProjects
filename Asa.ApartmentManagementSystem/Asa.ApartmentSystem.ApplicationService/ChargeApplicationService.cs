using ASa.ApartmentManagement.Core.ChargeCalculation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Asa.ApartmentSystem.ApplicationService
{
    public class ChargeApplicationService
    {
        IUnitOfWorkFactory _unitOfWorkFactory;
        public ChargeApplicationService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory ?? throw new ArgumentNullException(nameof(unitOfWorkFactory));
        }

        public async Task CalculateCharge(DateTime from, DateTime to)
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                var expenses = await uow.ExpensRepository.GetAllByDateAsync(from, to);
                var building = await uow.BuildingRepository.GetBuildingAsync();
                var chanrges = building.CalulateCharge(expenses);
                await uow.ChargeRepository.AddRangeAsync(chanrges);
                await uow.Commit();
            }
        }
    }
}
