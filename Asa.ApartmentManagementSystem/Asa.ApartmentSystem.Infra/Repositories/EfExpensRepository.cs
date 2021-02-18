using ASa.ApartmentManagement.Core.ChargeCalculation.Domain;
using ASa.ApartmentManagement.Core.ChargeCalculation.Repositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ASa.ApartmentManagement.Core.ChargeCalculation.Domain.CalculationFormula;

namespace Asa.ApartmentSystem.Infra.Repositories
{
    public class EfExpensRepository : IExpensRepository
    {
        ApartmentDbContext _dbContext;
        public EfExpensRepository(ApartmentDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public Task<IEnumerable<Expens>> GetAllByDateAsync(DateTime from, DateTime to)
        {
            var expenses = _dbContext.Expenses.Where(x => x.From >= from && x.To <= to).ToList();
            //Load All Categories,
            foreach (var item in expenses)
            {
                //Find realated category
                var formulaName = "";// From related category
                item.Formula = CalculationFormulaFactory.Create(formulaName);
            }
            return null;
        }
    }
}
