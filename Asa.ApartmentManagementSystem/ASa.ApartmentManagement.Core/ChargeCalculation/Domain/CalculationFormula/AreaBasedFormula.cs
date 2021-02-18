using System;
using System.Collections.Generic;
using System.Text;

namespace ASa.ApartmentManagement.Core.ChargeCalculation.Domain.CalculationFormula
{
    [CalculationFormula("بر حسب مساحت واحد")]
    public class AreaBasedFormula : IFormula
    {
        public List<(int payerId, decimal amount)> Calculate(Expens expens, Building building, int unit)
        {
            var result = new List<(int payerId, decimal amount)>();
            result.Add((payerId: 1, amount: 1458));
            return result;
        }
    }
}
