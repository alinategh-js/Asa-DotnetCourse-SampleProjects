using System;
using System.Collections.Generic;
using System.Text;

namespace ASa.ApartmentManagement.Core.ChargeCalculation.Domain.CalculationFormula
{
    [CalculationFormula("مقدار ثابت")]
    public class FixedAmountFormula : IFormula
    {
        public List<(int payerId, decimal amount)> Calculate(Expens expens, Building building, int unit)
        {
            //var dayOfLiving=building.GetDayOfLivingForPayers(unit,expens.From,expens.To);
            ////Calculate based on date for each payer
            //throw new NotImplementedException();
            var result = new List<(int payerId, decimal amount)>();
            result.Add((payerId: 1, amount: 1458));
            return result;
        }
    }
}
