using ASa.ApartmentManagement.Core.ChargeCalculation.Domain.CalculationFormula;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Asa.ApartmentSystem.ApplicationService
{
    public class FormulaApplicationService
    {
        public IEnumerable<FormulaNameDto> GetAll() => CalculationFormulaFactory.GetAll().Select(x => new FormulaNameDto { Title = x.Title, Type = x.TypeName });
    }
}
